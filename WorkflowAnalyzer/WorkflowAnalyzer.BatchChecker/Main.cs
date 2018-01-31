using System;
using System.ComponentModel.Composition;
using System.Xml.Linq;
using PluginManager;
using PluginManager.Plugins;

namespace WorkflowAnalyzer.BatchChecker
{
    [Export(typeof(IExternalExtension))]
    [ExportMetadata("PluginType", PluginLoader.PluginType.UtilityExtension)]
    class Main : RuleDefinitionPluginBase
    {
        public override void Execute()
        {
            bool valid = PluginHelper.HandlesBatching;
            Name = "Batching Check";
            Description = valid ? "Workflow correctly handles batching." : "Workflow does not correctly handle batching.";
            Url = new Uri("https://community.nintex.com");
            Valid = valid;
            Category = valid ? "0" : "2";
            Parameters = new[]


            {
                new XElement("Version", "Correctly handles batched actions: " + valid), 
            };

        }
    }
}
