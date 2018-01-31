using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class SPSafeEmailServers
    {
        [XmlElement("AcceptMailFromAllMailServer")]
        public bool AcceptMailFromAllMailServer;
    }
}
