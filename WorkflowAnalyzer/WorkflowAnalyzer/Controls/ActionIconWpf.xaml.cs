using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace WorkflowAnalyzer.Controls
{
    /// <summary>
    /// Interaction logic for ActionIconWpf.xaml
    /// </summary>
    public partial class ActionIconWpf : UserControl
    {
        private NWActionConfig _actionConfig;

        public ActionIconWpf()
        {
            InitializeComponent();
        }

        public ActionIconWpf(NWActionConfig actionConfig)
        {

            InitializeComponent();

            _actionConfig = actionConfig;

            if (actionConfig.TLabel != null) TLabelTextbox.Text = actionConfig.TLabel;
            if (actionConfig.BLabel != null) BLabelTextbox.Text = actionConfig.BLabel;
            if (actionConfig.LLabel != null) LLabelTextbox.Text = actionConfig.LLabel;
            if (actionConfig.RLabel != null) RLabelTextbox.Text = actionConfig.RLabel;

            BitmapImage icon = new BitmapImage();

            icon.BeginInit();
            icon.UriSource = new Uri(@"/WorkflowAnalyzer;component/wfimages/" + actionConfig.Type + ".png");
            icon.EndInit();

            if (actionConfig.Type != null) ActionIconPictureBox.Source = icon;

            //= Application.StartupPath + "\\wfimages\\" + actionConfig.Type + ".png";
        }

        public void Connect(int connectionId, object target)
        {
            throw new NotImplementedException();
        }
    }
}
