using System.Windows.Forms;
using PluginManager.SupportPackage;

namespace SupportPackage.Controls
{
    public partial class NintexDatabaseSetupControl : UserControl
    {
        public NintexDatabaseSetupControl(NintexDatabaseSetup nintexDatabaseSetup)
        {
            InitializeComponent();

            ConfigurationDBValue.Text = nintexDatabaseSetup.ConfigurationDatabase;

            foreach (string dbConnection in nintexDatabaseSetup.ContentDatabases)
            {
                ContentDatabaseFlowPanelControl.Controls.Add(new NintexContentDatabaseControl(dbConnection));
            }

            foreach (DatabaseMapping databaseMapping in nintexDatabaseSetup.NintexDatabaseMapping)
            {
                DatabaseMappingFlowControl.Controls.Add(new NintexDatabaseMappingControl(databaseMapping));
            }
        }
    }
}
