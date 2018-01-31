using System;

namespace PluginManager.Plugins
{
    /// <summary>
    /// Interface for all plug-in types. Use IExternalExtension instead of using this interface directly.
    /// </summary>
    public interface IPlugin
    {

        /// <summary>
        /// Used to box an object to be passed to PluginManager.
        /// </summary>
        object InteropObject { get; set; }

        /// <summary>
        /// Identifies the plug-in type.
        /// </summary>
        PluginLoader.PluginType PluginType { get; }

        /// <summary>
        /// Executes Main "Execute()" method in plug-in.
        /// </summary>
        void Execute();

        /// <summary>
        /// Builds/instantiates InteropObject.
        /// </summary>
        void BuildInteropObject();

        /// <summary>
        /// Event triggers when plug-in loading starts.
        /// </summary>
        event EventHandler OnPluginLoad;
        /// <summary>
        /// Event triggers when plug-in is loaded..
        /// </summary>
        event EventHandler OnPluginLoaded;
        /// <summary>
        /// Event triggers when plug-in unloading starts.
        /// </summary>
        event EventHandler OnPluginUnload;
        /// <summary>
        /// Event triggers when plug-in is unloaded.
        /// </summary>
        event EventHandler OnPluginUnloaded;
        /// <summary>
        /// Event triggers when plug-in Main "Execute()" method starts.
        /// </summary>
        event EventHandler OnExecuteStart;
        /// <summary>
        /// Event triggers when plug-in Main "Execute()" method is running.
        /// </summary>
        event EventHandler OnExecuting;
        /// <summary>
        /// Event triggers when plug-in Main "Execute()" method completes.
        /// </summary>
        event EventHandler OnExecuteComplete;
    }
}
