
using System.Xml.Serialization;

namespace PluginManager.NWF
{
    public class AssociationColumn
    {
        [XmlAttribute("Source")]
        public string Source;

        [XmlAttribute("Type")]
        public string Type;

        [XmlAttribute("Id")]
        public string Id;

        [XmlAttribute("FieldDefinitionXml")]
        public string FieldDefinitionXml;

        [XmlAttribute("DisplayName")]
        public string DisplayName;

        [XmlAttribute("DisplayNameLowerCase")]
        public string DisplayNameLowerCase;

        [XmlAttribute("EncodedDataFieldName")]
        public string EncodedDataFieldName;
    }
}
