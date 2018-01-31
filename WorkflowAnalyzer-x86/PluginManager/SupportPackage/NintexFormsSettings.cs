

using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class NintexFormsSettings
    {
        [XmlElement("IsDatabaseProvisioned")]
        public bool IsDatabaseProvisioned;

        [XmlElement("IsLiveFormsInstalled")]
        public bool IsLiveFormsInstalled;

        [XmlElement("DatabaseSetup")]
        public NintexFormsDatabaseSetup DatabaseSetup;

        [XmlElement("LiveFormsSettings")] 
        public NintexLiveFormsSettings LiveFormsSettings;
    }
}
