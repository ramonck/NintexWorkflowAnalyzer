using System;
using System.ComponentModel.Composition;
using System.Xml.Linq;
using PluginManager.Plugins;
using PluginManager.NWF;
using System.Collections.Generic;

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
        /// Dictionary to store interop properties in.
        /// </summary>
        public Dictionary<string, object> PropertyBag {get; set;}

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
        /// Recursively process action collection and execute delegate.
        /// </summary>
        /// <param name="method">Delegate that will be executed on each action.</param>
        /// <param name="actions">Collection of actions to process.</param>
        public void RecursiveActionSearch(Action<NWActionConfig> method, List<NWActionConfig> actions)
        {
            while (actions.Count > 0)
            {
                var action = actions[0];
                actions.RemoveAt(0);

                foreach (var child in action.ChildActivities)
                {
                    actions.Add(child);
                }

                method(action);
            }
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
