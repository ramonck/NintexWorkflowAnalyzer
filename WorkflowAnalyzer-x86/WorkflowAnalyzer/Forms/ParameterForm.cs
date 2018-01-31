using System;
using System.Windows.Forms;
using PluginManager.NWF;

namespace WorkflowAnalyzer.Forms
{
    public partial class ParameterForm : Form
    {
        public ParameterForm()
        {
            InitializeComponent();
        }

        public ParameterForm(Parameter parameter)
        {
            InitializeComponent();
            Text = "Nintex Workflow Analyzer" + parameter.Name;
            NameTextBox.Text = parameter.Name;
            Value.Text = parameter.PrimitiveValue.Value;
            ValueType.Text = parameter.PrimitiveValue.ValueType;
        }

        private void ParameterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
