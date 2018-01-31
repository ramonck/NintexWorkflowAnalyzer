

using System.Xml;
using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{

    public class NintexWorkflowLog
    {
        [XmlElement("WorkflowName")] 
        public string WorkflowName;

        [XmlElement("InternalState")] 
        public string InternalState;

        [XmlElement("StartDate")] 
        public string StartDate;

        [XmlElement("StartTimeShort")] 
        public string StartTimeShort;

        [XmlElement("StartTimeLong")] 
        public string StartTimeLong;

        [XmlElement("StartDateShort")] 
        public string StartDateShort;

        [XmlElement("StartDateLong")] 
        public string StartDateLong;

        [XmlElement("LastModifiedDate")] 
        public string LastModifiedDate;

        [XmlElement("LastModifiedTimeShort")] 
        public string LastModifiedTimeShort;

        [XmlElement("LastModifiedTimeLong")] 
        public string LastModifiedTimeLong;

        [XmlElement("LastModifiedDateShort")] 
        public string LastModifiedDateShort;

        [XmlElement("LastModifiedDateLong")] 
        public string LastModifiedDateLong;

        [XmlElement("WorkflowInstanceId")] 
        public string WorkflowInstanceId;

        //[XmlElement("")] 
        //public Activities

        //[XmlElement("")] 
        //public HumanTasks

        [XmlElement("WorkflowHistory")] 
        public XmlDocument WorkflowHistory;


    }
}
