using System.Collections.Generic;
using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class NintexDatabaseSetup
    {
        [XmlElement("ConfigurationDatabase")]
        public string ConfigurationDatabase;

        [XmlArrayItem("string", typeof(string))]
        [XmlArray("ContentDatabases")]
        public List<string> ContentDatabases;

        [XmlElement("CurrentDatabaseVersion")]
        public string CurrentDatabaseVersion;

        [XmlElement("LatestDatabaseVersion")]
        public string LatestDatabaseVersion;

        [XmlArrayItem("DatabaseMappings", typeof (DatabaseMapping))] [XmlArray("DatabaseMappings")] 
        public List<DatabaseMapping> NintexDatabaseMapping;

    }
}
