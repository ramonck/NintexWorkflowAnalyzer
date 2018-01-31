using System;
using System.Windows.Forms;
using PluginManager.NWF;

namespace WorkflowAnalyzer.Forms
{
    public partial class ActionConfigurationForm : Form
    {
        private NWActionConfig _actionConfig;

        public ActionConfigurationForm()
        {
            InitializeComponent();
        }

        public ActionConfigurationForm(NWActionConfig actionConfig)
        {
            InitializeComponent();

            _actionConfig = actionConfig;

        }

        private void ActionConfigurationForm_Load(object sender, EventArgs e)
        {
            Text = "Nintex Workflow Analyzer - " + _actionConfig.TLabel;

            TLabel.Text = _actionConfig.TLabel;
            RLabel.Text = _actionConfig.RLabel;
            LLabel.Text = _actionConfig.LLabel;
            BLabel.Text = _actionConfig.BLabel;

            TLabelCustom.Checked = _actionConfig.TCustLbl;
            RLabelCustom.Checked = _actionConfig.RCustLbl;
            LLabelCustom.Checked = _actionConfig.LCustLbl;
            BLabelCustom.Checked = _actionConfig.BCustLbl;


            CommentType.Text = _actionConfig.CommentType;
            CustomComments.Text = _actionConfig.CustomComments;
            ShowCustomComments.Checked = _actionConfig.ShowCustomComments;
            ExpectedDuration.Text = _actionConfig.ExpectedDuration.ToString();
            Assembly.Text = _actionConfig.Assembly;
            Type.Text = _actionConfig.Type;
            ConditionUse.Text = _actionConfig.ConditionUse;

            HideUI.Checked = _actionConfig.HideUI;
            IsValid.Checked = _actionConfig.IsValid;
            LogMessage.Checked = _actionConfig.LogMessage;
            HasDefaultMessage.Checked = _actionConfig.HasDefaultMessage;

            UserContext.Text = _actionConfig.UserContext;
            SelectedUserContext.Text = _actionConfig.SelectedUserContext;

            foreach (Parameter parameter in _actionConfig.Parameters)
            {
                ParameterPanel.Controls.Add(new Controls.Parameter(parameter));
            }
        }


    }
}
