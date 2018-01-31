using System.Windows.Forms;
using SupportPackage.Properties;

namespace SupportPackage.Controls
{
    public partial class ValidationControl : UserControl
    {
        public ValidationControl()
        {
            InitializeComponent();
        }

        public void SetFalse()
        {
            Validation.Image = Resources.Error;
        }

        public void SetTrue()
        {
            Validation.Image = Resources.Success;
        }

    }
}
