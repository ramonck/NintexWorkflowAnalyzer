
using System;
using System.Collections;
using System.Xml;

namespace WorkflowAnalyzer
{
    internal class NWFWrapper : NWFHandler
    {
        /// <summary>
        /// List Associated with Workflow.
        /// </summary>
        public string AssociatedListName
        {
            get
            {
                var selectSingleNode = NwfXmlDocument.SelectSingleNode("/ExportedWorkflowWithListMetdata/ListReferences/ListReference/ListName");
                if (
                    selectSingleNode != null)
                {
                    return selectSingleNode.InnerText;
                }
                else
                {
                    return string.Empty;
                }
                    
            }
            protected set { AssociatedListName = value; }

        }

        /// <summary>
        /// Workflow Type Site/List
        /// </summary>
        public string WorkflowType
        {
            get
            {
                var selectSingleNode = NwfXmlDocument.SelectSingleNode(@"/ExportedWorkflowWithListMetdata/WorkflowType");
                if (selectSingleNode != null)
                {
                    return selectSingleNode.InnerText;
                }
                return string.Empty;

            }
            protected set { WorkflowType = value; }
        }

        /// <summary>
        /// Count of all activities in the workflow
        /// </summary>
        public int ActionCount
        {
            get {
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(NwfXmlDocument.ChildNodes.Item(1).FirstChild.InnerText);
            Int32 actioncount = 0;
            foreach (XmlElement xelement in (xdoc.GetElementsByTagName("NWActionConfig")))
            {
                if (xelement.SelectSingleNode("TLabel").InnerText != "" & xelement.SelectSingleNode("TLabel").InnerText != "State" & xelement.SelectSingleNode("TLabel").InnerText != "IfElseBranch")
                {
                    actioncount++;
                }
            }

            return actioncount;
        }
        }
        
        /// <summary>
        /// Does the workflow start when a new item is created?
        /// </summary>
        public bool StartsOnCreateEvent
        {
            get
            {
                XmlDocument NWFInternal = new XmlDocument();
                NWFInternal.LoadXml(NwfXmlInternalDocument.OuterXml);
                var selectSingleNode = NWFInternal.SelectSingleNode("/ExportedWorkflow/Configurations/ActionConfigs/NWActionConfig[1]/Parameters/Parameter[@Name='StartOnCreate']/PrimitiveValue/@Value");
                Boolean onCreateEvent = selectSingleNode != null && Boolean.Parse(selectSingleNode.InnerXml);
                return onCreateEvent;
            }
        }

        /// <summary>
        /// Does the workflow start when an item is modified?
        /// </summary>
        public bool StartsOnModifiedEvent
        {
            get
            {
                XmlDocument NWFInternal = new XmlDocument();
                NWFInternal.LoadXml(NwfXmlInternalDocument.OuterXml);
                var selectSingleNode = NWFInternal.SelectSingleNode("/ExportedWorkflow/Configurations/ActionConfigs/NWActionConfig[1]/Parameters/Parameter[@Name='StartOnChange']/PrimitiveValue/@Value");
                Boolean onModifiedEvent = selectSingleNode != null && Boolean.Parse(selectSingleNode.InnerXml);
                return onModifiedEvent;
            }
        }

        /// <summary>
        /// Does the workflow start when an item is created or modified?
        /// </summary>
        public bool UsesEventReceiver
        {
            get
            {
                if (StartsOnCreateEvent || StartsOnModifiedEvent)
                {
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// Version of Nintex Workflow the export is from.
        /// </summary>
        public int VersionOfNintexWorkflow
        {
            get
            {
                try
                {
                    var selectSingleNode = NwfXmlDocument.SelectSingleNode("/ExportedWorkflowWithListMetdata/Version");
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
        }

        #region Nintex Workflow Version Checks
        public Boolean NwVersionIsCurrent() //Checks if Nintex Workflow version is current
        {
            switch (int.Parse(VersionOfNintexWorkflow.ToString().Substring(0, 1)))
            {
                case 1:
                    if (VersionOfNintexWorkflow >= Properties.Settings.Default.NW2007CurrentVersion)
                    {
                        return true;
                    }
                    return false;

                case 2:
                    if (VersionOfNintexWorkflow == 23110) //bad build check
                    {
                        return false;
                    }
                    if (VersionOfNintexWorkflow >= Properties.Settings.Default.NW2010CurrentVersion)
                    {
                        return true;
                    }
                    return false;

                case 3:
                    if (VersionOfNintexWorkflow >= Properties.Settings.Default.NW2013CurrentVersion)
                    {
                        return true;
                    }
                    return false;
            }
            return false;
        }
        #endregion

        #region Nintex Workflow Timing Checks

        public Boolean HasPauseStartAction()
        {
            XmlDocument nwfInternal = new XmlDocument();
            nwfInternal.LoadXml(NwfXmlInternalDocument.OuterXml);
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
        public Boolean HasCorrectTiming()
        {
            if ((UsesEventReceiver & HasPauseStartAction()) || !UsesEventReceiver)
            {
                return true;
            }
            return false;
        }

        #endregion

        #region Nintex Workflow Batching Checks

        public Boolean HandlesBatching()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(NwfXmlInternalDocument.OuterXml);
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

        #endregion

        #region Nintex Workflow Workflow Size Checks
        public Boolean IsNwfSizeTooLarge()
        {
            return NwfFileSize >= 500;
        }
        #endregion


    
        

    }
}
