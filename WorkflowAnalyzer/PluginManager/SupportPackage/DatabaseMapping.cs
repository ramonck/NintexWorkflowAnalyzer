
using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class DatabaseMapping
    {
        [XmlElement("SiteId")]
        public string SiteId;

        [XmlElement("SiteUrl")]
        public string SiteUrl;

        [XmlElement("DatabaseName")]
        public string DatabaseName;
    }
}
