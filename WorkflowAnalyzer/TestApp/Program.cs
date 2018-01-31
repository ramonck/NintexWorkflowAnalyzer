using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAInterop;

namespace TestApp
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            NWFLoader loader = new NWFLoader();

            OpenFileDialog dialog = new OpenFileDialog();

            dialog.ShowDialog();

            loader.LoadWorkflowFile(dialog.FileName);

            var testing = WorkflowAnalyzer.PluginHelper.ActionCount;

        }
    }
}
