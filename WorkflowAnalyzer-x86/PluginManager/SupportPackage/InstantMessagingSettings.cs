using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class InstantMessagingSettings
    {
        [XmlElement("IMMode")]
        public string IMMode;

        [XmlElement("FromSIPAddress")]
        public string FromSIPAddress;

        [XmlElement("FromDomainUser")]
        public string FromDomainUser;

        [XmlElement("IMServer")]
        public string IMServer;

        [XmlElement("IMTransport")]
        public string IMTransport;
    }
}
