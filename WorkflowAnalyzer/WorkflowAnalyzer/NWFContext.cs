
using PluginManager.NWF;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using WorkflowAnalyzer.Properties;

namespace WorkflowAnalyzer
{
    public class NWFContext : INWFContext, INWFXPath
    {
        private string _nwfDocument;
        public XmlDocument NWFXmlDocument { get; set; }
        public XmlDocument NWFXmlInternalDocument { get; set; }
        public XmlDocument NWFXmlModified { get; set; }
        public NintexWorkflowDocument NintexWorkflowExternalContext { get; set; }
        public ExportedWorkflow NintexWorkflowInternalContext { get; set; }

        internal NWFContext(string nwfDocument)
        {
            _nwfDocument = nwfDocument;
            ExtractXmlDocument();
            ExtractInternalDocument();
            NWFObjectLoader();
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

        public bool HasRecursiveConfiguration()
        {
            //Does the workflow even start on modification?
            if (!StartsOnModifiedEvent()) return false;

            #region Update List Item
            //Grab all Update List Item actions
            List<PluginManager.NWF.NWActionConfig> UpdateListItemActionConfigs = NintexWorkflowInternalContext.Configurations.ActionConfigs.FindAll(c => c.Type == "Nintex.Workflow.Activities.Adapters.SPUpdateItemWithKeyAdapter");

            //Check if Update List Item actions are updating ThisItem
            if (UpdateListItemActionConfigs.Find(c => c.Parameters.Find(p => p.Name == "ThisItem").PrimitiveValue.Value == "true") != null)
            {
                return true;
            };

            //Check for references in Update List Item by List Id
            foreach (ListReference listReference in NintexWorkflowExternalContext.ListReferences.FindAll(l => l.IsSourceList == true))
            {
                if (UpdateListItemActionConfigs.FindAll(c => c.Parameters.Find(p => p.Name == "ListId").PrimitiveValue.Value.ToUpper() == "{" + listReference.ListId.ToUpper() + "}").Count != 0)
                {
                    return true;
                }
            }
            #endregion

            #region Set Field

            //Grab all Set Field actions
            List<PluginManager.NWF.NWActionConfig> SetFieldActionConfigs = NintexWorkflowInternalContext.Configurations.ActionConfigs.FindAll(c => c.Type == "Nintex.Workflow.Activities.Adapters.SPSetFieldWithKeyAdapter");

            //Check if Update List Item actions are updating ThisItem
            if (SetFieldActionConfigs.Count != 0)
            {
                return true;
            };

            #endregion

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
                PluginHelper.HasRecursiveConfiguration = HasRecursiveConfiguration();
                PluginHelper.HasLogNestedInLoop = HasLogInLoop();
                PluginHelper.IsLoggingProgressDataInLoop = IsLoggingProgressDataInLoop();
                PluginHelper.UsingStoredCredentials = UsingStoredCredentials();
                PluginHelper.CallWebServiceUsesTokenEncoding = CallWebServiceUsesTokenEncoding();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace, @"Error Populating Plugin Helper.");
            }

        }

        private void NWFObjectLoader()
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                NWFXmlDocument.Save(memoryStream);

                memoryStream.Position = 0;

                XmlSerializer serializer = new XmlSerializer(typeof(NintexWorkflowDocument));

                var externalDoc = (NintexWorkflowDocument)serializer.Deserialize(memoryStream);

                PluginHelper.NintexWorkflowExternalContext = externalDoc;

                NintexWorkflowExternalContext = externalDoc;
            }

            using (MemoryStream memoryStream = new MemoryStream())
            {
                NWFXmlInternalDocument.Save(memoryStream);

                memoryStream.Position = 0;

                XmlSerializer serializer = new XmlSerializer(typeof(ExportedWorkflow), new Type[] { typeof(NWAutoStartCondition) });

                var internalDoc = (ExportedWorkflow)serializer.Deserialize(memoryStream);

                PluginHelper.NintexWorkflowInternalContext = internalDoc;

                NintexWorkflowInternalContext = internalDoc;
            }

        }

        public bool HasLogInLoop()
        {
            List<PluginManager.NWF.NWActionConfig> LoopActionConfigs = NintexWorkflowInternalContext.Configurations.ActionConfigs.FindAll(c => c.Type == "Nintex.Workflow.Activities.Adapters.NWLoopAdapter" || c.Type == "Nintex.Workflow.Activities.Adapters.NWForEachLoopAdapter");

            foreach (PluginManager.NWF.NWActionConfig action in LoopActionConfigs)
            {
                if (action.ChildActivities[0].ChildActivities.FindAll(c => c.Type == "Nintex.Workflow.Activities.Adapters.NWWriteToHistoryListAdapter").Count > 0) return true;
            }

            return false;
        }

        public bool IsLoggingProgressDataInLoop()
        {
            List<PluginManager.NWF.NWActionConfig> LoopActionConfigs = NintexWorkflowInternalContext.Configurations.ActionConfigs.FindAll(c => c.Type == "Nintex.Workflow.Activities.Adapters.NWLoopAdapter" || c.Type == "Nintex.Workflow.Activities.Adapters.NWForEachLoopAdapter");

            foreach (PluginManager.NWF.NWActionConfig action in LoopActionConfigs)
            {
                var foo = action.ChildActivities[0].ChildActivities.FindAll(c => c.HideUI == true).Count;

                if (action.ChildActivities[0].ChildActivities.FindAll(c => c.HideUI == true).Count > 0) return true;
            }

            return false;
        }

        public bool UsingStoredCredentials()
        {
            List<PluginManager.NWF.NWActionConfig> CredentialActionConfigs = NintexWorkflowInternalContext.Configurations.ActionConfigs.FindAll(c => c.Parameters.FindAll(p => p.Name == "Username").Count > 0);

            foreach (NWActionConfig action in CredentialActionConfigs)
            {
                string usr = null;
                string password = null;
                try
                {
                    usr = action.Parameters.Find(p => p.Name == "Username").PrimitiveValue.Value;
                    password = action.Parameters.Find(p => p.Name == "Password").PrimitiveValue.Value;
                }
                catch(Exception e)
                {
                    continue;
                }

                Regex regex = new Regex(@"{WFConstant:.*}");
                Match match = regex.Match(usr);
                if (!match.Success && password != "")
                {
                    return false;
                }
            }

            return true;
        }

        public bool CallWebServiceUsesTokenEncoding()
        {
            List<PluginManager.NWF.NWActionConfig> WebServiceActionConfigs = NintexWorkflowInternalContext.Configurations.ActionConfigs.FindAll(c => c.Type == "Nintex.Workflow.Activities.Adapters.NWCallWebServiceAdapter");

            foreach (NWActionConfig action in WebServiceActionConfigs)
            {
                try
                {
                    if (!bool.Parse(action.Parameters.Find(p => p.Name == "IsSetToSoapBuilderMode").PrimitiveValue.Value))
                    {
                        continue;
                    }
                    if (!bool.Parse(action.Parameters.Find(p => p.Name == "HtmlEncodeTokens").PrimitiveValue.Value))
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    continue;
                }
            }

            return true;
        }
    }
}
