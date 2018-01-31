
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PluginManager.NWF
{
    [XmlInclude(typeof(ExpressionCondition))]
    public class NWActionConfig
    {
        
        [XmlAttribute("LCustLbl")] 
        public bool LCustLbl;

        [XmlAttribute("RCustLbl")]
        public bool RCustLbl;

        [XmlAttribute("TCustLbl")]
        public bool TCustLbl;

        [XmlAttribute("BCustLbl")]
        public bool BCustLbl;

        [XmlAttribute("ShowCustomComments")]
        public bool ShowCustomComments;

        [XmlAttribute("CommentType")]
        public string CommentType;

        [XmlElement("HideUI")] 
        public bool HideUI;

        [XmlElement("Enabled")] 
        public bool Enabled;

        [XmlElement("InhertiedEnabled")] 
        public bool InheritedEnabled;

        [XmlElement("BLabel")] 
        public string BLabel;

        [XmlElement("LLabel")] 
        public string LLabel;

        [XmlElement("RLabel")] 
        public string RLabel;

        [XmlElement("TLabel")] 
        public string TLabel;

        [XmlElement("CustomComments")] 
        public string CustomComments;

        [XmlElement("ExpectedDuration")] 
        public int ExpectedDuration;

        [XmlElement("Assembly")] 
        public string Assembly;

        [XmlElement("Type")] 
        public string Type;

        [XmlElement("IsValid")] 
        public bool IsValid;

        [XmlElement("ConditionUse")] 
        public string ConditionUse;

        [XmlArrayItem("Parameter", typeof(Parameter))]
        [XmlArray("Parameters")]
        public List<Parameter> Parameters;

        [XmlArrayItem("Approver", typeof(Approver))]
        [XmlArray("Approvers")]
        public List<Approver> Approvers;

        [XmlArrayItem("Variable", typeof(NWVariable))]
        [XmlArray("WorkflowVariables")]
        public List<NWVariable> Variable;

        [XmlElement("Message")] 
        public NWMessage Message;

        [XmlArrayItem("NWActionConfig", typeof(NWActionConfig))]
        [XmlArray("ChildActivities")]
        public List<NWActionConfig> ChildActivities;

        [XmlArrayItem("Outcome", typeof(NWOutcome))]
        [XmlArray("Outcomes")]
        public List<NWOutcome> Outcomes;

        [XmlArrayItem("AssociationColumn", typeof(AssociationColumn))]
        [XmlArray("AssociationColumns")]
        public List<AssociationColumn> AssociationColumns;

        [XmlArrayItem("AutoStartCondition", typeof(NWAutoStartCondition))]
        [XmlArray("StartOnChangeConditions")]
        public List<NWAutoStartCondition> StartOnChangeConditions;

        [XmlElement("LogMessage")] 
        public bool LogMessage;

        [XmlElement("HistoryNote")] 
        public string HistoryNote;

        [XmlElement("HasDefaultMessage")] 
        public bool HasDefaultMessage;

        [XmlElement("UserContext")] 
        public string UserContext;

        [XmlElement("SelectedUserContext")] 
        public string SelectedUserContext;

        [XmlArrayItem("WorkflowStatus", typeof(string))]
        [XmlArray("CustomWorkflowStatuses")]
        public List<string> CustomWorkflowStatuses;

        //[XmlElement("ExtensionProperties")]
        //public string ExtensionProperties;

        [XmlElement("ValueStorages")] 
        public ValueStorages ValueStorages;

    }
}
