
using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class NintexLiveFormsSettings
    {
        [XmlElement("IsDatabaseProvisioned")]
        public bool IsDatabaseProvisioned;

        [XmlElement("IsLiveFormsInstalled")]
        public bool IsLiveFormsInstalled;
    }
}
