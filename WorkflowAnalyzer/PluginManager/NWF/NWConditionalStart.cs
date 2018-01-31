using System.Xml.Serialization;

namespace PluginManager.NWF
{
    public class NWConditionalStart
    {
        [XmlElement("AutoStartCondition")]
        public NWAutoStartCondition AutoStartCondition;
    }
}
