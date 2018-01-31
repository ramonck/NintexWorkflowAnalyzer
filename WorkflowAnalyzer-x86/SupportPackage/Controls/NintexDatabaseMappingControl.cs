using System.Windows.Forms;
using PluginManager.SupportPackage;

namespace SupportPackage.Controls
{
    public partial class NintexDatabaseMappingControl : UserControl
    {
        public NintexDatabaseMappingControl(DatabaseMapping databaseMapping)
        {
            InitializeComponent();

            SiteIdValue.Text = databaseMapping.SiteId;
            SiteUrlValue.Text = databaseMapping.SiteUrl;
            DatabaseNameValue.Text = databaseMapping.DatabaseName;
        }
    }
}
