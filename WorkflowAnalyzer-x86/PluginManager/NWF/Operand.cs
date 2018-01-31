
using System.Xml.Serialization;

namespace PluginManager.NWF
{
    public class Operand
    {
        [XmlAttribute("Type")] 
        public string Type;

        [XmlElement("Value")]
        public string Value;

        [XmlElement("PreviousValue")]
        public bool PreviousValue;

    }
}
