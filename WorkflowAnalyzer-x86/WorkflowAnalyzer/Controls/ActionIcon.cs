using System.Windows.Forms;
using PluginManager.NWF;
using WorkflowAnalyzer.Forms;

namespace WorkflowAnalyzer.Controls
{
    public partial class ActionIcon : UserControl
    {
        private NWActionConfig _actionConfig;

        public ActionIcon()
        {
            InitializeComponent();
        }

        public ActionIcon(NWActionConfig actionConfig)
        {
            InitializeComponent();

            _actionConfig = actionConfig;

            if (actionConfig.TLabel != null) TLabelTextbox.Text = actionConfig.TLabel;
            if (actionConfig.BLabel != null) BLabelTextbox.Text = actionConfig.BLabel;
            if (actionConfig.LLabel != null) LLabelTextbox.Text = actionConfig.LLabel;
            if (actionConfig.RLabel != null) RLabelTextbox.Text = actionConfig.RLabel;
            if (actionConfig.Type != null) ActionIconPictureBox.ImageLocation = Application.StartupPath + "\\wfimages\\" + actionConfig.Type + ".png";
        }

        private void ActionIconPictureBox_DoubleClick(object sender, System.EventArgs e)
        {
            ActionConfigurationForm form = new ActionConfigurationForm(_actionConfig);
            form.Show();
        }


    }
}
