using System.Windows.Forms;

namespace SupportPackage.Controls
{
    public partial class EmailSettingControl : UserControl
    {
        public EmailSettingControl(PluginManager.SupportPackage.FarmSummary farmSummary)
        {
            InitializeComponent();

            EnableIncomingValue.Text = farmSummary.EmailSetting.IncomingEmail.EnableIncoming.ToString();
            UseAutoSettingsValue.Text = farmSummary.EmailSetting.IncomingEmail.UseAutomaticSettings.ToString();
            ServiceModeValue.Text = farmSummary.EmailSetting.IncomingEmail.DirectoryManagementService.ServiceMode;
            AcceptFromAuthenticatedValue.Text =
                farmSummary.EmailSetting.IncomingEmail.DirectoryManagementService.AcceptFromAuthenticatedUsersOnly
                    .ToString();
            AllowCreateDistributionValue.Text =
                farmSummary.EmailSetting.IncomingEmail.DirectoryManagementService
                    .AllowCreateDistributionGroupsFromSharePointSites.ToString();
            AcceptMailFromAllValue.Text =
                farmSummary.EmailSetting.IncomingEmail.SafeEmailServers.AcceptMailFromAllMailServer.ToString();
            CharSetValue.Text = farmSummary.EmailSetting.OutgoingEmail.CharacterSet;

        }
    }
}
