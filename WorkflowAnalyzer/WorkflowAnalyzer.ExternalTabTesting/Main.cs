using System.ComponentModel.Composition;
using PluginManager;
using PluginManager.Plugins;

namespace WorkflowAnalyzer.BrowserTab
{
    [Export(typeof(IExternalExtension))] //Must Export as IExternalExtension.
    public class Main : ExternalWebBrowserTabPluginBase //Must inherit from PluginManager.ExternalWebBrowserTabPluginBase.
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

            //Sets the HTML Document to be rendered in the browser.
            TabBrowser.DocumentText = "<h1>Hello World!</h1>";

        }
    }
}
