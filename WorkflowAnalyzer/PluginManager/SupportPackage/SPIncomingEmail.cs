

using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class SPIncomingEmail
    {
        [XmlElement("EnableIncoming")]
        public bool EnableIncoming;
        [XmlElement("UseAutomaticSettings")]
        public bool UseAutomaticSettings;
        [XmlElement("DirectoryManagementService")]
        public SPDirectoryManagementService DirectoryManagementService;
        [XmlElement("SafeEmailServers")]
        public SPSafeEmailServers SafeEmailServers;

    }
}
