

using System.Xml.Serialization;

namespace PluginManager.NWF
{
    public class Parameter
    {
        [XmlAttribute("Name")]
        public string Name;

        [XmlElement("PrimitiveValue")]
        public ParameterPrimitiveValue PrimitiveValue;
    }
}
