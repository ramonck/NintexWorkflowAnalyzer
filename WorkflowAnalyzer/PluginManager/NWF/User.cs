
using System.Xml.Serialization;

namespace PluginManager.NWF
{
    public class User
    {
        [XmlElement("UserID")]
        public string UserID;

        [XmlElement("IsDomainGroup")]
        public bool IsDomainGroup;

        [XmlElement("IsSPGroup")]
        public bool IsSPGroup;

        [XmlElement("IsUser")]
        public bool IsUser;
    }
}
