using System.ComponentModel.Composition;
using System.Windows.Forms;
using PluginManager.Plugins;

namespace PluginManager
{
    /// <summary>
    /// Plug-in Base class for Web Tab plug-ins.
    /// </summary>
    [Export(typeof(IExternalExtension))]
    public class ExternalWebBrowserTabPluginBase : ExternalTabPluginBase
    {
        
        /// <summary>
        /// Browser object to be loaded in Tab.
        /// </summary>
        public WebBrowser TabBrowser = new WebBrowser();

        /// <summary>
        /// Passes Tab and Browser object to PluginLoader.
        /// </summary>
        public override void BuildInteropObject()
        {
            TabBrowser.Dock = DockStyle.Fill;
            ExternalTabPage.Controls.Add(TabBrowser);
            InteropObject = ExternalTabPage;
        }
    }
}
