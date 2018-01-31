
using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class GlobalSettings
    {
        [XmlElement("EmailSettings")] 
        public NintexEmailSettings EmailSettings;

        [XmlElement("InstantMessagingSettings")] 
        public InstantMessagingSettings IMSettings;

        [XmlElement("EnforceSafeLoop")] 
        public bool EnforceSafeLoop;

        [XmlElement("EnforceAllowedActionsAtRuntime")] 
        public bool EnforceAllowedActionsAtRuntime;

        [XmlElement("AllowExecuteSqlActionUseAppPool")] 
        public bool AllowExecuteSqlActionUseAppPool;

        [XmlElement("AllowWorkflowSchedulesImpersonateSystem")] 
        public bool AllowWorkflowSchedulesImpersonateSystem;

        [XmlElement("AllowSendNotificationOnBehalf")] 
        public bool AllowSendNotificationOnBehalf;

        [XmlElement("AllowRunNowOnExternalData")] 
        public bool AllowRunNowOnExternalData;

        [XmlElement("AllowRunNowOnSitesUseChangeApproval")] 
        public bool AllowRunNowOnSitesUseChangeApproval;
    }
}
