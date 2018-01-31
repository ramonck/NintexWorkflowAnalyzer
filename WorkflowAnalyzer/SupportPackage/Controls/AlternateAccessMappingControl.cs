
using System.Windows.Forms;
using PluginManager.SupportPackage;

namespace SupportPackage.Controls
{
    public partial class AlternateAccessMappingControl : UserControl
    {
        public AlternateAccessMappingControl(SPAlternateAccessMapping alternateAccessMapping)
        {
            InitializeComponent();

            InternalUrlValue.Text = alternateAccessMapping.InternalUrl;
            ZoneValue.Text = alternateAccessMapping.Zone;
            PublicUrlValue.Text = alternateAccessMapping.PublicUrlForZone;
        }
    }
}
