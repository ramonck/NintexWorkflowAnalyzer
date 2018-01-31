
using System.Xml;
using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class WorkflowInfo
    {
        [XmlElement("WorkflowInstanceId")]
        public string WorkflowInstanceId;

        [XmlElement("SiteId")]
        public string SiteId;

        [XmlElement("WebId")]
        public string WebId;

        [XmlElement("ListId")]
        public string ListId;

        [XmlElement("WorkflowName")]
        public string WorkflowName;

        [XmlElement("WorkflowType")]
        public string WorkflowType;

        [XmlElement("NWFFile")]
        public string NWFFile;

        [XmlElement("XOML")] 
        public string XOML;

        [XmlElement("ConfigXml")] 
        public string ConfigXml;

        [XmlElement("Rules")] 
        public string Rules;

        [XmlElement("WorkflowInitiator")]
        public string WorkflowInitiator;

        [XmlElement("WorkflowState")]
        public string WorkflowState;

        [XmlElement("WorkflowLog")]
        public NintexWorkflowLog WorkflowLog;
    }
}
