
using System.Xml.Serialization;

namespace PluginManager.NWF
{
    public class ValueStorage
    {
        [XmlAttribute("VariableName")]
        public string VariableName;

        [XmlAttribute("ValueIdentifier")]
        public string ValueIdentifier;

        [XmlAttribute("VariableType")]
        public string VariableType;
    }
}
