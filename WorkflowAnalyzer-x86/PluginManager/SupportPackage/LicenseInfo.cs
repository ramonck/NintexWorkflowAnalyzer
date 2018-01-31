
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class LicenseInfo
    {
        [XmlArrayItem("InstalledProductInfo", typeof(InstalledProductInfo))]
        [XmlArray("InstalledProducts")]
        public List<InstalledProductInfo> InstalledProducts;
    }
}
