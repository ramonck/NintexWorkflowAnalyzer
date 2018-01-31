
using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class NintexFormsDatabaseSetup
    {
        [XmlElement("DatabaseName")]
        public string DatabaseName;

        [XmlElement("ConnectionString")]
        public string ConnectionString;

    }
}
