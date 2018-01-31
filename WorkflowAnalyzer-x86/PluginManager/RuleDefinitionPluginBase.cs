using System;
using System.ComponentModel.Composition;
using System.Xml.Linq;
using PluginManager.Plugins;

namespace PluginManager
{
    /// <summary>
    /// Plug-in Base class for Rule Definition plug-ins.
    /// </summary>
    [Export(typeof(IExternalExtension))]
    public class RuleDefinitionPluginBase : IExternalExtension
    {
        /// <summary>
        /// Boxed object to be passed to PluginLoader. By Default this object is set to RuleDefinition defined by properties found in this class.
        /// </summary>
        public object InteropObject { get; set; }

        /// <summary>
        /// Returns a PluginType of RuleDefinition
        /// </summary>
        public PluginLoader.PluginType PluginType
        {
            get { return PluginLoader.PluginType.RuleDefinition; }
        }

        private RuleDefinition Definition()
        {
            RuleDefinition rule = new RuleDefinition();
            rule.Description = Description;
            rule.Name = Name;
            rule.Url = Url;
            rule.Valid = Valid;
            rule.Parameters = Parameters;
            rule.Category = Category;
            return rule;
        }

        /// <summary>
        /// Name of Rule.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Category of rule.
        /// 0 - Informational
        /// 1 - Warning
        /// 2 - Problematic
        /// </summary>
        public string Category { get; protected set; }

        /// <summary>
        /// Version of plug-in.
        /// </summary>
        public int Version { get; protected set; }

        /// <summary>
        /// Indicates whether rule validated.
        /// </summary>
        public bool Valid { get; protected set; }

        /// <summary>
        /// Description of Rule.
        /// </summary>
        public string Description { get; protected set; }

        /// <summary>
        /// URL to article for more information.
        /// </summary>
        public Uri Url { get; protected set; }

        /// <summary>
        /// Additional parameters or information to provide.
        /// </summary>
        public XElement[] Parameters { get; protected set; }

        /// <summary>
        /// Main method of plug-in. All validation code should be placed here.
        /// </summary>
        public virtual void Execute()
        {

        }

        /// <summary>
        /// By default this method loads a RuleDefinition object to the PluginLoader.
        /// </summary>
        public virtual void BuildInteropObject()
        {
            InteropObject = Definition();
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
