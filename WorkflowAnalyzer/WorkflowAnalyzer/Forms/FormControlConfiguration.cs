using PluginManager.NF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkflowAnalyzer.Forms
{
    public partial class FormControlConfiguration : Form
    {
        public FormControlConfiguration()
        {
            InitializeComponent();
        }

        public FormControlConfiguration(FormControlProperties control)
        {
            InitializeComponent();

            this.Text = control.DisplayName + " - " + control.UniqueId;


            StringBuilder sb = new StringBuilder();
            foreach (string str in control.Border)
            {
                sb.Append(str).Append(", ");
            }

            if(sb.Length > 0)
            sb.Remove(sb.Length - 2, 2);

            textBox11.Text = sb.ToString();


            textBox1.Text = control.BorderColor;
            textBox2.Text = control.BorderStyle;
            textBox3.Text = control.BackgroundColor;
            textBox4.Text = control.CanResizeAtRuntime.ToString();
            textBox5.Text = control.VerticalAlign;
            textBox6.Text = control.PaddingWidth.ToString();
            textBox7.Text = control.VerticalHeight;
            textBox8.Text = control.HorizontalWidth;
            textBox9.Text = control.IsVisible.ToString();
            textBox10.Text = control.IsLocked.ToString();

            textBox12.Text = control.ControlCssClass;
            textBox13.Text = control.CssClass;
            textBox14.Text = control.ExposedClientIdJavaScriptVariable;
            textBox15.Text = control.ExposeClientIdAsJavaScriptVariable.ToString();

            textBox16.Text = control.Name;
            textBox17.Text = control.DisplayName;
            textBox18.Text = control.AlternateText;

            textBox19.Text = control.ControlVersion;
            textBox20.Text = control.FormControlTypeUniqueId;
            textBox21.Text = control.UniqueId;
            textBox22.Text = control.FormType;
            textBox23.Text = control.IsDirty.ToString();
            textBox24.Text = control.TabIndex.ToString();
            textBox25.Text = control.ControlMode;

            textBox26.Text = control.DefaultValue;
            textBox27.Text = control.DefaultValueSource;
            textBox28.Text = control.VariableSource;
            textBox29.Text = control.ValueToCompare;

            textBox30.Text = control.DialogTitle;
            textBox31.Text = control.HelpText;
            textBox32.Text = control.HelpTextSet;
            textBox33.Text = control.RequiredErrorMessage;
            textBox34.Text = control.CompareErrorMessage;
            textBox35.Text = control.CustomErrorMessage;

            textBox36.Text = control.UseCustomValidation.ToString();
            textBox37.Text = control.CustomvalidationFunction;
            textBox38.Text = control.UseCompareValidation.ToString();
            textBox39.Text = control.CompareOperator;
            textBox40.Text = control.ControlToCompare;
            textBox41.Text = control.CompareTo;

            textBox42.Text = control.IsRequired.ToString();
            textBox43.Text = control.IsEnabled.ToString();

            textBox45.Text = control.MaximumEntities.ToString();
            textBox44.Text = control.InRepeater.ToString();
            textBox46.Text = control.DataFieldDisplayName;
            textBox47.Text = control.DataField;

            textBox48.Text = control.MultiSelectChanged.ToString();
            textBox49.Text = control.PickerDialogToolTip;
            textBox50.Text = control.SharePointGroup;
            textBox51.Text = control.MultiSelect.ToString();
            
        }

        private void FormControlConfiguration_Load(object sender, EventArgs e)
        {

        }
    }
}
