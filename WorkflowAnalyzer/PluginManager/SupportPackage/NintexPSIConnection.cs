

using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class NintexPSIConnection
    {
        [XmlElement("Name")]
        public string Name;

        [XmlElement("Description")]
        public string Description;

        [XmlElement("Key")]
        public string Key;

        [XmlElement("PWASiteUrl")]
        public string PWASiteUrl;

        [XmlElement("ProxyUsername")]
        public string ProxyUsername;

        [XmlElement("ProxyUserUid")]
        public string ProxyUserUid;

        [XmlElement("PWASiteId")]
        public string PWASiteId;

        [XmlElement("IsWindowsUser")]
        public bool IsWindowsUser;

        [XmlElement("LanguageCulture")]
        public string LanguageCulture;

        [XmlElement("LocaleCulture")]
        public string LocaleCulture;
    }
}
