
using System;
using System.ComponentModel.Composition;
using System.Windows.Forms;
using PluginManager.Plugins;

namespace PluginManager
{
    /// <summary>
    /// Plug-in Base class for Tab plug-ins.
    /// </summary>
    [Export(typeof(IExternalExtension))]
    public class ExternalTabPluginBase : IExternalExtension
    {
        /// <summary>
        /// Boxed object to be passed to PluginLoader. By Default this object is set to RuleDefinition defined by properties found in this class.
        /// </summary>
        public virtual object InteropObject { get; set; }

        /// <summary>
        /// Returns a PluginType of ExternalTab.
        /// </summary>
        public PluginLoader.PluginType PluginType
        {
            get {return PluginLoader.PluginType.ExternalTab;}
        }

        /// <summary>
        /// TabPage object to be passed to PluginLoader.
        /// </summary>
        public TabPage ExternalTabPage = new TabPage();

        /// <summary>
        /// Main method of plug-in. 
        /// </summary>
        public virtual void Execute()
        {

        }

        /// <summary>
        /// By default this method loads a TabPage object to the PluginLoader.
        /// </summary>
        public virtual void BuildInteropObject()
        {
            InteropObject = ExternalTabPage;
        }

        /// <summary>
        /// Event triggers when plug-in loading starts.
        /// </summary>
        public event EventHandler OnPluginLoad;
        /// <summary>
        /// Event triggers when plug-in is loaded..
        /// </summary>
        public event EventHandler OnPluginLoaded;
        /// <summary>
        /// Event triggers when plug-in unloading starts.
        /// </summary>
        public event EventHandler OnPluginUnload;
        /// <summary>
        /// Event triggers when plug-in is unloaded.
        /// </summary>
        public event EventHandler OnPluginUnloaded;
        /// <summary>
        /// Event triggers when plug-in Main "Execute()" method starts.
        /// </summary>
        public event EventHandler OnExecuteStart;
        /// <summary>
        /// Event triggers when plug-in Main "Execute()" method is running.
        /// </summary>
        public event EventHandler OnExecuting;
        /// <summary>
        /// Event triggers when plug-in Main "Execute()" method completes.
        /// </summary>
        public event EventHandler OnExecuteComplete;

    }
}
