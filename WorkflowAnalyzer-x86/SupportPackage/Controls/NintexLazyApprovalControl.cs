using System.Windows.Forms;
using PluginManager.SupportPackage;

namespace SupportPackage.Controls
{
    public partial class NintexLazyApprovalControl : UserControl
    {
        public NintexLazyApprovalControl(LazyApprovalSettings lazyApprovalSettings)
        {
            InitializeComponent();

            EnabledValue.Text = lazyApprovalSettings.IsEnabled.ToString();
            EmailAliasValue.Text = lazyApprovalSettings.EmailAlias;

        }
    }
}
