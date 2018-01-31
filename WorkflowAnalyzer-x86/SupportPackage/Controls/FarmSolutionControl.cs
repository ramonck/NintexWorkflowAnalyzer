
using System.Windows.Forms;
using PluginManager.SupportPackage;
using SupportPackage.Forms;

namespace SupportPackage.Controls
{
    public partial class FarmSolutionControl : UserControl
    {
        private SPSolution _solution;

        public FarmSolutionControl(SPSolution solution)
        {
            InitializeComponent();

            _solution = solution;

            SolutionName.Text = solution.SolutionName;
        }

        private void SolutionName_Click(object sender, System.EventArgs e)
        {
            FarmSolutionDetail frm = new FarmSolutionDetail(_solution);

            frm.Show();
        }


    }
}
