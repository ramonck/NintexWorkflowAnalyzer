using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PluginManager.NWF;

namespace WorkflowAnalyzer.WPF.Controls
{
    /// <summary>
    /// Interaction logic for WFAction.xaml
    /// </summary>
    public partial class WFAction : UserControl
    {
        public WFAction()
        {
            InitializeComponent();
        }

        public WFAction(NWActionConfig config)
        {
            InitializeComponent();

            ActionTitle.Content = config.TLabel;

            foreach (NWActionConfig cfg in config.ChildActivities)
            {
                this.ChildPanel.Children.Add(new WFAction(cfg));
            }
        }

    }
}
