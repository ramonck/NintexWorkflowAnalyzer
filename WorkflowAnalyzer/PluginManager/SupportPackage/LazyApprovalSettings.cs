using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class LazyApprovalSettings
    {
        [XmlElement("IsEnabled")]
        public bool IsEnabled;

        [XmlElement("EmailAlias")]
        public string EmailAlias;
    }
}
