using System.Windows.Forms;
using PluginManager.SupportPackage;

namespace SupportPackage.Controls
{
    public partial class NintexGlobalSettingsControl : UserControl
    {
        public NintexGlobalSettingsControl(GlobalSettings settings)
        {
            InitializeComponent();

            SMTPValue.Text = settings.EmailSettings.SmtpServer;
            FromAddressValue.Text = settings.EmailSettings.FromAddress;
            ReplyAddressValue.Text = settings.EmailSettings.ReplyToAddress;
            OutgoingEmailCharValue.Text = settings.EmailSettings.OutgoingEmailCharSet;
            OutgoingSMSCharValue.Text = settings.EmailSettings.OutgoingSMSCharSet;
            UseCSSInEmailValue.Text = settings.EmailSettings.UseCSSInEmail;
            EmailStyleSheetUrlValue.Text = settings.EmailSettings.EmailStyleSheetUrl;

            IMModeValue.Text = settings.IMSettings.IMMode;
            FromSIPAddressValue.Text = settings.IMSettings.FromSIPAddress;
            FromFomainUserValue.Text = settings.IMSettings.FromDomainUser;
            IMServerValue.Text = settings.IMSettings.IMServer;
            IMTransportValue.Text = settings.IMSettings.IMTransport;

            EnforceSafeLoopValue.Text = settings.EnforceSafeLoop.ToString();
            EnforceAllowActionsValue.Text = settings.EnforceAllowedActionsAtRuntime.ToString();
            AllowWorkflowSchedulesValue.Text = settings.AllowWorkflowSchedulesImpersonateSystem.ToString();
            AllowSendNotificationValue.Text = settings.AllowSendNotificationOnBehalf.ToString();
            ARNonExternalValue.Text = settings.AllowRunNowOnExternalData.ToString();
            ARNonSitesValue.Text = settings.AllowRunNowOnSitesUseChangeApproval.ToString();
        }
    }
}
