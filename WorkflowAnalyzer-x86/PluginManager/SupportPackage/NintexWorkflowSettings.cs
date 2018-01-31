
using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class NintexWorkflowSettings
    {
        [XmlElement("GlobalSettings")]
        public GlobalSettings NintexGlobalSettings;

        [XmlElement("LazyApprovalSettings")]
        public LazyApprovalSettings NintexLazyApprovalSettings;

        [XmlElement("DatabaseSetup")]
        public NintexDatabaseSetup DatabaseSetup;

        [XmlElement("NintexLiveWorkflowSettings")]
        public NintexLiveWorkflowSettings LiveWorkflowSettings;
    }
}
