using System.Windows.Forms;

namespace SupportPackage.Controls
{
    public partial class NintexContentDatabaseControl : UserControl
    {
        public NintexContentDatabaseControl(string databaseConnectionString)
        {
            InitializeComponent();

            DataSource.Text = databaseConnectionString;
        }
    }
}
