
using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using WorkflowAnalyzer.Properties;

namespace WorkflowAnalyzer
{
    public class NWFContext : INWFContext, INWFXPath
    {
        private string _nwfDocument;
        public XmlDocument NWFXmlDocument { get; set; }
        public XmlDocument NWFXmlInternalDocument { get; set; }
        public XmlDocument NWFXmlModified { get; set; }

        

        internal NWFContext(string nwfDocument)
        {
            _nwfDocument = nwfDocument;
            ExtractXmlDocument();
            ExtractInternalDocument();

            PopulatePluginHelper();
        }

        public int NWFFileSize()
        {
            //return int.Parse((new FileInfo(_filePath).Length / 1024).ToString(CultureInfo.InvariantCulture));
            return (_nwfDocument.Length/1024);
        }


        /// <summary>
        /// List Associated with Workflow.
        /// </summary>
        public string AssociatedListName()
        {
            var selectSingleNode = NWFXmlDocument.SelectSingleNode("/ExportedWorkflowWithListMetdata/ListReferences/ListReference/ListName");
            if (
                selectSingleNode != null)
            {
                return selectSingleNode.InnerText;
            }

            return string.Empty;
        }

        /// <summary>
        /// Workflow Type Site/List
        /// </summary>
        public string WorkflowType()
        {
            var selectSingleNode = NWFXmlDocument.SelectSingleNode(@"/ExportedWorkflowWithListMetdata/WorkflowType");
            if (selectSingleNode != null)
            {
                return selectSingleNode.InnerText;
            }
            return string.Empty;
        }

        /// <summary>
        /// Count of all activities in the workflow less sequence adapters.
        /// </summary>
        public int ActionCount()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(NWFXmlDocument.ChildNodes.Item(1).FirstChild.InnerText);
            Int32 actioncount = 0;
            foreach (XmlElement xelement in (xdoc.GetElementsByTagName("NWActionConfig")))
            {
                //Added to address issue where a Sequence adapter does not have a TLabel and results in a null exception when counting actions.
                if (xelement.SelectSingleNode("TLabel") == null) continue;

                if (xelement.SelectSingleNode("TLabel").InnerText != "" &
                    xelement.SelectSingleNode("TLabel").InnerText != "State" &
                    xelement.SelectSingleNode("TLabel").InnerText != "IfElseBranch")
                {
                    actioncount++;
                }
            }

            

            return actioncount;
        }

        /// <summary>
        /// Count of all activities in the workflow.
        /// </summary>
        public int RealActionCount()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(NWFXmlDocument.ChildNodes.Item(1).FirstChild.InnerText);
            Int32 actioncount = 0;

            foreach (XmlElement xelement in (xdoc.GetElementsByTagName("NWActionConfig")))
            {
                    actioncount++;
            }

            return actioncount;
        }

        /// <summary>
        /// Does the workflow start when an item is created or modified?
        /// </summary>
        public bool UsesEventReceiver()
        {
                if (StartsOnCreateEvent() || StartsOnModifiedEvent())
                {
                    return true;
                }
                return false;
        }

        /// <summary>
        /// Does the workflow start when a new item is created?
        /// </summary>
        public bool StartsOnCreateEvent() //Needs refactoring! Duplicate references to the same XML :(
        {
            XmlDocument NWFInternal = new XmlDocument();
            NWFInternal.LoadXml(NWFXmlInternalDocument.OuterXml);
            var selectSingleNode = NWFInternal.SelectSingleNode("/ExportedWorkflow/Configurations/ActionConfigs/NWActionConfig[1]/Parameters/Parameter[@Name='StartOnCreate']/PrimitiveValue/@Value");
            Boolean onCreateEvent = selectSingleNode != null && Boolean.Parse(selectSingleNode.InnerXml);
            return onCreateEvent;
        }

        /// <summary>
        /// Does the workflow start when an item is modified?
        /// </summary>
        public bool StartsOnModifiedEvent() //Needs refactoring! Duplicate references to the same XML :(
        {
            XmlDocument NWFInternal = new XmlDocument();
            NWFInternal.LoadXml(NWFXmlInternalDocument.OuterXml);
            var selectSingleNode = NWFInternal.SelectSingleNode("/ExportedWorkflow/Configurations/ActionConfigs/NWActionConfig[1]/Parameters/Parameter[@Name='StartOnChange']/PrimitiveValue/@Value");
            Boolean onModifiedEvent = selectSingleNode != null && Boolean.Parse(selectSingleNode.InnerXml);
            return onModifiedEvent;
        }

        /// <summary>
        /// Version of Nintex Workflow the export is from.
        /// </summary>
        public int VersionOfNintexWorkflow()
        {
            try
            {
                var selectSingleNode = NWFXmlDocument.SelectSingleNode("/ExportedWorkflowWithListMetdata/Version");
                if (selectSingleNode != null)
                {
                    return int.Parse(selectSingleNode.InnerText);
                }
                return 0;

            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Checks if version is current.
        /// </summary>
        /// <returns>boolean value.</returns>
        public bool NWVersionIsCurrent()
        {
            switch (int.Parse(VersionOfNintexWorkflow().ToString().Substring(0, 1)))
            {
                case 1:
                    if (VersionOfNintexWorkflow() >= Properties.Settings.Default.NW2007CurrentVersion)
                    {
                        return true;
                    }
                    return false;

                case 2:
                    if (VersionOfNintexWorkflow() == 23110) //bad build check
                    {
                        return false;
                    }
                    if (VersionOfNintexWorkflow() >= Properties.Settings.Default.NW2010CurrentVersion)
                    {
                        return true;
                    }
                    return false;

                case 3:
                    if (VersionOfNintexWorkflow() >= Properties.Settings.Default.NW2013CurrentVersion)
                    {
                        return true;
                    }
                    return false;
            }
            return false;
        }

        public bool HasCorrectTiming()
        {
            if ((UsesEventReceiver() & HasPauseStartAction()) || !UsesEventReceiver())
            {
                return true;
            }
            return false;
        }

        public bool HasPauseStartAction() //Needs refactoring! Duplicate references to the same XML :(
        {
            XmlDocument nwfInternal = new XmlDocument();
            nwfInternal.LoadXml(NWFXmlInternalDocument.OuterXml);
            var selectSingleNode = nwfInternal.SelectSingleNode("/ExportedWorkflow/Configurations/ActionConfigs/NWActionConfig[2]/Type");
            if (selectSingleNode != null)
            {
                String actionCheck = selectSingleNode.InnerXml;
                if (actionCheck == "Nintex.Workflow.Activities.Adapters.NWDelayForAdapter")
                {
                    return true;
                }
            }
            return false;
        }

        public bool HandlesBatching() //Needs refactoring! Duplicate references to the same XML :(
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(NWFXmlInternalDocument.OuterXml);
            XmlNodeList nodes = doc.SelectNodes("//NWActionConfig");
            IEnumerator item = nodes.GetEnumerator();
            Int32 index = new Int32();
            index = 0;
            while (item.MoveNext())
            {
                XmlNode node = (XmlNode)item.Current;
                node = node.SelectSingleNode("Type");
                index++;
                XmlNode nextnode = (XmlNode)nodes.Item(index);
                if (index < nodes.Count)
                {
                    nextnode = nextnode.SelectSingleNode("Type");

                    if ((ValidationHelper.IsBatchedAction(node.InnerText) & (nextnode.InnerText != "Nintex.Workflow.Activities.Adapters.NWCommitAdapter")))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool NwfTooLarge()
        {
            return NWFFileSize() >= 500;
        }

        private void ExtractInternalDocument()
        {
            var xmlNode = NWFXmlDocument.ChildNodes.Item(1);
            if (xmlNode != null)
            {
                String wfconfig = xmlNode.FirstChild.InnerText;
                NWFXmlInternalDocument = new XmlDocument();
                NWFXmlInternalDocument.LoadXml(wfconfig);
                PluginHelper.NwfXmlInternalDocument = NWFXmlInternalDocument;
            }
        }

        private void ExtractXmlDocument()
        {
            NWFXmlDocument = new XmlDocument();

            NWFXmlDocument.LoadXml(_nwfDocument.Replace(Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble()), ""));
        }

        private string GetWorkflowTitle()
        {
            XmlNode wfTitleNode = (GetWorkflowConfigurationNodeListByXPath("//Title")[0]);
            return wfTitleNode.InnerText;
        }

        public void SaveStringToFile(String Text, String extension)
        {
            SaveFileDialog saveString = new SaveFileDialog();
            saveString.Filter = extension + " Files (*." + extension + ")|*." + extension + "";
            saveString.FileName = GetWorkflowConfigurationNodeListByXPath("//Title")[0].InnerText + " " + DateTime.Now.ToString("MM-dd-yy H-mm-ss");
            saveString.ShowDialog();

            if (saveString.FileName != "")
            {
                File.WriteAllText(saveString.FileName, Text);
            }
        }

        public XmlNodeList GetWorkflowConfigurationNodeListByXPath(String Query)
        {
            return NWFXmlInternalDocument.SelectNodes(Query);
        }

        public XmlNodeList GetNWFNodeListByXPath(String Query)
        {
            return NWFXmlDocument.SelectNodes(Query);
        }

        public void SetStagedWorkflowConfiguration(String XML)//Possible refactor needed (editor code)
        {
            try
            {
                if (NWFXmlModified != null)
                {
                    NWFXmlModified.ChildNodes.Item(1).FirstChild.InnerText = XML;
                }
                else
                {
                    NWFXmlModified = new XmlDocument();
                    NWFXmlModified.LoadXml(NWFXmlDocument.InnerXml);
                    NWFXmlModified.ChildNodes.Item(1).FirstChild.InnerText = XML;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Failed to validate XML: " + e.ToString());
            }
        }

        private void PopulatePluginHelper()
        {
            try
            {
                PluginHelper.NwfXmlDocument = NWFXmlDocument;
                PluginHelper.ActionCount = ActionCount();
                PluginHelper.RealActionCount = RealActionCount();
                PluginHelper.AssociatedListName = AssociatedListName();
                PluginHelper.WorkflowSize = NWFFileSize();
                PluginHelper.StartsOnCreateEvent = StartsOnCreateEvent();
                PluginHelper.UsesEventReceiver = UsesEventReceiver();
                PluginHelper.StartsOnModifiedEvent = StartsOnModifiedEvent();
                PluginHelper.VersionOfNintexWorkflow = VersionOfNintexWorkflow();
                PluginHelper.WorkflowType = WorkflowType();
                PluginHelper.HandlesBatching = HandlesBatching();
                PluginHelper.HandlesTiming = HasCorrectTiming();
                PluginHelper.ApplicationRootPath = Application.StartupPath;
                PluginHelper.PluginPath = Application.StartupPath + "\\Plugins\\";
                PluginHelper.WebAssetsPath = Application.StartupPath + "\\Assets\\";
                PluginHelper.JQueryLibrary = Resources.JQuery.Replace("{Assets}", Application.StartupPath + "\\assets\\");
                PluginHelper.WorkflowTitle = GetWorkflowTitle();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace, @"Error Populating Plugin Helper.");
            }

        }
    }
}
