using System.Windows.Forms;

namespace SupportPackage.Controls
{
    public partial class NintexLiveWorkflowSettingsControl : UserControl
    {
        public NintexLiveWorkflowSettingsControl(PluginManager.SupportPackage.NintexLiveWorkflowSettings nintexLiveWorkflowSettings)
        {
            InitializeComponent();

            EnabledValue.Text = nintexLiveWorkflowSettings.IsLiveEnabled.ToString();
            AllowCatalogInDesignerValue.Text = nintexLiveWorkflowSettings.AllowLiveCatalogInDesigner.ToString();
            AllowViewCommentsAndRatingsValue.Text = nintexLiveWorkflowSettings.AllowViewCommentsAndRatings.ToString();
            AllowCommentsAndRatingsValue.Text = nintexLiveWorkflowSettings.AllowRatingsAndComments.ToString();
        }
    }
}
