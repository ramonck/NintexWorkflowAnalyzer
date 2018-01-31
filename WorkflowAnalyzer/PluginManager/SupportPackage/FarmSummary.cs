using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    [Serializable, XmlRoot("FarmData")]
    public class FarmSummary
    {
        [XmlElement("DateCreated")]
        public DateTime SPFarmCreationDateTime;

        [XmlElement("DatabaseVersion")]
        public string SPDatabaseVersion;

        [XmlElement("DatabaseServer")]
        public string SPDatabaseServer;

        [XmlElement("DatabaseName")]
        public string SPDatabaseName;

        public SPEmailSetting EmailSetting;

        [XmlArrayItem("FarmAlternateAccessMapping", typeof(SPAlternateAccessMapping))]
        [XmlArray("AlternateAccessMappings")]
        public List<SPAlternateAccessMapping> AlternateAccessMappings;

        [XmlArrayItem("FarmServer", typeof(SPServer))]
        [XmlArray("Servers")]
        public List<SPServer> Servers;

        [XmlArrayItem("FarmFeature", typeof(SPFeature))]
        [XmlArray("Features")]
        public List<SPFeature> Features;

        [XmlArrayItem("FarmSolution", typeof(SPSolution))]
        [XmlArray("Solutions")]
        public List<SPSolution> Solutions;
    }
}
