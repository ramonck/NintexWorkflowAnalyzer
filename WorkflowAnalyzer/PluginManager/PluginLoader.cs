using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Windows.Forms;
using PluginManager.Plugins;


namespace PluginManager
{

    /// <summary>
    /// Handles loading and parsing of plug-ins.
    /// </summary>
    public class PluginLoader
    {
        [ImportMany(typeof(IExternalExtension))]
        IEnumerable<Lazy<IExternalExtension>> plugins;

        /// <summary>
        /// BPA Rule Definition plug-ins.
        /// </summary>
        public List<RuleDefinition> BpaDefinitions = new List<RuleDefinition>();
        /// <summary>
        /// Tab Page plug-ins.
        /// </summary>
        public List<TabPage> TabPages = new List<TabPage>();

        private List<Lazy<IExternalExtension>> _ruleDefinitionPlugins = new List<Lazy<IExternalExtension>>();
        private List<Lazy<IExternalExtension>> _utilityExtensionPlugins = new List<Lazy<IExternalExtension>>();
        private List<Lazy<IExternalExtension>> _externalTabPlugins = new List<Lazy<IExternalExtension>>();


        /// <summary>
        /// Specifies the type of plug-in.
        /// </summary>
        public enum PluginType
        {
            RuleDefinition,
            UtilityExtension,
            ExternalTab
        };
        CompositionContainer _container;
        AggregateCatalog _catalog = new AggregateCatalog();

        /// <summary>
        /// Default constructor.
        /// </summary>
        public PluginLoader()
        {
            _catalog.Catalogs.Add(new DirectoryCatalog(Application.StartupPath + "\\Plugins"));

            try
            {
                _container = new CompositionContainer(_catalog);
                _container.ComposeParts(this);
                ParsePlugins();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.StackTrace, "Error Loading Plug-in");

            }

        }

        internal void ParsePlugins()
        {
            foreach (Lazy<IExternalExtension> i in plugins)
            {
                switch (i.Value.PluginType)
                {
                    case PluginType.RuleDefinition:
                        _ruleDefinitionPlugins.Add(i);
                        break;

                    case PluginType.UtilityExtension:
                        _utilityExtensionPlugins.Add(i);
                        break;

                    case PluginType.ExternalTab:
                        _externalTabPlugins.Add(i);
                        break;
                }
            }
        }

        /// <summary>
        /// Executes Main "Execute()" method on each Rule Definition plug-in.
        /// </summary>
        public void InitializeRuleDefinitionPlugins()
        {
            foreach (Lazy<IExternalExtension> plugin in _ruleDefinitionPlugins)
            {
                LoadRulePlugin(plugin);
            }
        }

        /// <summary>
        /// Executes Main "Execute()" method on each Utility plug-in.
        /// </summary>
        public void InitializeUtilityPlugins()
        {
            foreach (Lazy<IExternalExtension> plugin in _utilityExtensionPlugins)
            {
                LoadUtilityPlugin(plugin);
            }
        }

        /// <summary>
        /// Executes Main "Execute()" method on each Tab plug-in including Web based Tabs.
        /// </summary>
        public void InitializeExternalTabPlugins()
        {
            foreach (Lazy<IExternalExtension> plugin in _externalTabPlugins)
            {
                LoadExternalTabPlugin(plugin);
            }
        }

        private void LoadRulePlugin(Lazy<IExternalExtension> plugin)
        {
            plugin.Value.Execute();
            plugin.Value.BuildInteropObject();
            BpaDefinitions.Add(plugin.Value.InteropObject as RuleDefinition);

        }

        private void LoadUtilityPlugin(Lazy<IExternalExtension> plugin)
        {
            plugin.Value.Execute();
            plugin.Value.BuildInteropObject();

        }

        private void LoadExternalTabPlugin(Lazy<IExternalExtension> plugin)
        {
            plugin.Value.Execute();
            plugin.Value.BuildInteropObject();
            TabPages.Add(plugin.Value.InteropObject as TabPage);
        }
    }
}
