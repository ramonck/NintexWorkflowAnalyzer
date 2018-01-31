using System.Collections.Generic;
using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class NintexWorkflow4PSSettings
    {
        [XmlElement("DatabaseSetup")]
        public NintexWorkflow4PSDatabaseSetup DatabaseSetup;

        [XmlArrayItem("PWASite", typeof(NintexPWASite))]
        [XmlArray("ActivatedPWASites")]
        public List<NintexPWASite> ActivatedPwaSites;

        [XmlArrayItem("PSIConnection", typeof(NintexPSIConnection))]
        [XmlArray("StoredPsiConnections")]
        public List<NintexPSIConnection> StoredPsiConnections;
    }
}
