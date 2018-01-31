
using System.Xml.Serialization;

namespace PluginManager.NWF
{
    public class ApproverFrom
    {
        [XmlElement("IsDomainGroup")]
        public bool IsDomainGroup;

        [XmlElement("IsSPGroup")]
        public bool IsSPGroup;

        [XmlElement("IsUser")]
        public bool IsUser;
    }
}
