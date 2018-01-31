
using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class InstalledProductInfo
    {
        [XmlElement("ProductName")]
        public string ProductName;

        [XmlElement("InstalledVersion")]
        public string InstalledVersion;

        [XmlElement("ProductLicense")]
        public NintexProductLicense ProductLicense;
    }
}
