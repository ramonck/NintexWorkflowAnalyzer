

using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class NintexProductLicense
    {
        [XmlElement("LicenseId")]
        public string LicenseId;
    }
}
