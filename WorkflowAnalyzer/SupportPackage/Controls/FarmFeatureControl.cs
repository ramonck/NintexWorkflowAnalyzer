
using System.Drawing;
using System.Windows.Forms;

namespace SupportPackage.Controls
{
    public partial class FarmFeatureControl : UserControl
    {
        public FarmFeatureControl(string featureName, bool active)
        {
            InitializeComponent();

            ServiceName.Text = featureName;

            if (active) ServiceName.ForeColor = Color.Black;
        }
    }
}
