using System.Collections.Generic;
using System.Windows.Forms;
using PluginManager.SupportPackage;

namespace SupportPackage.Controls
{
    public partial class AlternateAccessMappingsControl : UserControl
    {
        public AlternateAccessMappingsControl(List<SPAlternateAccessMapping> alternateAccessMappings)
        {
            InitializeComponent();

            foreach (SPAlternateAccessMapping aam in alternateAccessMappings)
            {
                AAMFlowPanel.Controls.Add(new AlternateAccessMappingControl(aam));
            }

        }
    }
}
