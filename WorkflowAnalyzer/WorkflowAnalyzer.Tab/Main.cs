

using System.ComponentModel.Composition;
using System.Windows.Forms;
using PluginManager;
using PluginManager.Plugins;

namespace WorkflowAnalyzer.Tab
{
    [Export(typeof(IExternalExtension))] //Must Export as IExternalExtension.
    public class Main : ExternalTabPluginBase //Must inherit from PluginManager.ExternalTabPluginBase
    {
        ///WorkflowAnalyzer.PluginHelper static class can be used to obtain contextual information from the loaded workflow such
        /// as NWF external and internal XML.


        /// <summary>
        /// Executes when the tab is added to Nintex Workflow Analyzer.
        /// </summary>
        public override void Execute()
        {
            //Sets the title of the tab page.
            ExternalTabPage.Text = "My New Tab";
            ExternalTabPage.Controls.Add(new PictureBox()); //Add a WinForms control to the tab page.



        }
    }
}
