using System.Windows.Forms;
using PluginManager.SupportPackage;
using SupportPackage.Controls;

namespace SupportPackage.Forms
{
    public partial class FarmSummaryForm : Form
    {
        public FarmSummaryForm()
        {
            InitializeComponent();
        }

        public FarmSummaryForm(FarmSummary farmSummary, NintexProductData nintexProductData)
        {
            InitializeComponent();

            foreach (SPFeature feature in farmSummary.Features)
            {
                FeatureFlowPanel.Controls.Add(new FarmFeatureControl(feature.Name, feature.IsActive));
            }

            foreach (SPSolution solution in farmSummary.Solutions)
            {
                SolutionFlowPanel.Controls.Add(new FarmSolutionControl(solution));
            }

            ConfigurationFlowPanel.Controls.Add(new EmailSettingControl(farmSummary));
            ConfigurationFlowPanel.Controls.Add(new AlternateAccessMappingsControl(farmSummary.AlternateAccessMappings));

            NintexWorkflowFlowPanel.Controls.Add(new NintexGlobalSettingsControl(nintexProductData.Settings.WorkflowSettings.NintexGlobalSettings));
            NintexWorkflowFlowPanel.Controls.Add(new NintexLazyApprovalControl(nintexProductData.Settings.WorkflowSettings.NintexLazyApprovalSettings));
            NintexWorkflowFlowPanel.Controls.Add(new NintexDatabaseSetupControl(nintexProductData.Settings.WorkflowSettings.DatabaseSetup));
            NintexWorkflowFlowPanel.Controls.Add(new NintexLiveWorkflowSettingsControl(nintexProductData.Settings.WorkflowSettings.LiveWorkflowSettings));
        }



    }
}
