
using System.Xml.Serialization;

namespace PluginManager.NWF
{
    public class FieldReference
    {
        [XmlElement("InternalName")]
        public string InternalName;

        [XmlElement("DisplayName")]
        public string DisplayName;

        [XmlElement("FieldType")]
        public string FieldType;
    }
}
