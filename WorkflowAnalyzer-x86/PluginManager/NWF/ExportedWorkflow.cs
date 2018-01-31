
using System;
using System.Xml.Serialization;

namespace PluginManager.NWF
{
    [Serializable, XmlRoot("ExportedWorkflow")]
    public class ExportedWorkflow
    {
        [XmlNamespaceDeclarationsAttribute]
        public XmlSerializerNamespaces xsd;

        [XmlElement("Title")] 
        public string Title;

        [XmlElement("Description")] 
        public string Description;

        [XmlElement("Configurations")]
        public NWConfigurations Configurations;

        [XmlElement("Id")] 
        public string Id;
    }
}
