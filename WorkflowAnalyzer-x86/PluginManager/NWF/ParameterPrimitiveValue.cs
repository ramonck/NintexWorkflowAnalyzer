using System.Xml.Serialization;

namespace PluginManager.NWF
{
    public class ParameterPrimitiveValue
    {
        [XmlAttribute("Value")]
        public string Value;

        [XmlAttribute("ValueType")]
        public string ValueType;
    }
}
