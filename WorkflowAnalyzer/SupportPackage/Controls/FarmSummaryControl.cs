using System.Windows.Forms;

namespace SupportPackage.Controls
{
    public partial class FarmSummaryControl : UserControl
    {
        public FarmSummaryControl()
        {
            InitializeComponent();
        }

        public FarmSummaryControl(PluginManager.SupportPackage.FarmSummary farmSummary, PluginManager.SupportPackage.NintexProductData nintexProductData)
        {
            InitializeComponent();

            DatabaseVersion.Text = farmSummary.SPDatabaseVersion;
            DatabaseName.Text = farmSummary.SPDatabaseName;
            DBServerName.Text = farmSummary.SPDatabaseServer;
            moreInfoControl1.SetContext(new FarmSummaryMoreInfo());
            moreInfoControl1.SetFarmSummary(farmSummary);
            moreInfoControl1.SetNintexProductData(nintexProductData);
        }



    }
}
