using System;
using System.Windows.Forms;
using WorkflowAnalyzer.Forms;

namespace WorkflowAnalyzer.Controls
{
    public partial class Parameter : UserControl
    {
        private PluginManager.NWF.Parameter _parameter;

        public Parameter()
        {
            InitializeComponent();
        }

        public Parameter(PluginManager.NWF.Parameter parameter)
        {
            InitializeComponent();

            _parameter = parameter;
        }

        private void Parameter_Load(object sender, EventArgs e)
        {
            ParameterName.Text = _parameter.Name;
            toolTip1.SetToolTip(ParameterName, GetToolTipText());
        }

        private void ParameterName_DoubleClick(object sender, EventArgs e)
        {
            ParameterForm form = new ParameterForm(_parameter);
            form.Show();
        }

        private string GetToolTipText()
        {
            return string.Format("Parameter Value: {0}" + Environment.NewLine + "Parameter Type: {1} ",
                _parameter.PrimitiveValue.Value, _parameter.PrimitiveValue.ValueType);
        }
    }
}
