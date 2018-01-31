
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PluginManager.NWF
{
    [Serializable, XmlRoot("ExportedWorkflowWithListMetdata")]
    public class NintexWorkflowDocument
    {
        [XmlElement("ExportedWorkflowSeralized")] //Needs additional logic
        public string ExportedWorkflowSeralized;

        [XmlArrayItem("ListReference", typeof(ListReference))]
        [XmlArray("ListReferences")]
        public List<ListReference> ListReferences;

        [XmlElement("Version")]
        public string Version;

        [XmlElement("WorkflowType")]
        public string WorkflowType;

        [XmlElement("WorkflowId")]
        public string WorkflowId;
    }
}
