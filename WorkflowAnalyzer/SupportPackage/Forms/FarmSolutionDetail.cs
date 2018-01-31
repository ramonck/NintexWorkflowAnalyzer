using System.Windows.Forms;
using PluginManager.SupportPackage;

namespace SupportPackage.Forms
{
    public partial class FarmSolutionDetail : Form
    {
        private SPSolution _solution;

        public FarmSolutionDetail(SPSolution solution)
        {
            InitializeComponent();

            _solution = solution;

            Text = solution.SolutionName;

            PopulateValues();
        }

        private void PopulateValues()
        {
            TypeValue.Text = _solution.SolutionType;
            ContainsWebAppValue.Text = _solution.SolutionName;
            ContainsGACValue.Text = _solution.ContainsGlobalAssembly.ToString();
            ContainsCodeAccessSecValue.Text = _solution.ContainsCodeAccessSecurityPolicy.ToString();
            DeploymentStatusValue.Text = _solution.DeploymentStatus;
            DeployedToValue.Text = _solution.DeployedTo;
            LastResultValue.Text = _solution.LastOperationResult;
            LastOperationDetailsValue.Text = _solution.LastOperationDetails;
            LastOperationTimeValue.Text = _solution.LastOperationTime;

        }
    }
}
