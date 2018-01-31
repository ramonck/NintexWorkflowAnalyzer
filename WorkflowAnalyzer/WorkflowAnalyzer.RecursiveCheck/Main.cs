using System;
using System.ComponentModel.Composition;
using System.Xml.Linq;
using PluginManager;
using PluginManager.Plugins;
using System.Collections.Generic;
using PluginManager.NWF;

namespace WorkflowAnalyzer.RecursiveCheck
{
    [Export(typeof(IExternalExtension))]
    [ExportMetadata("PluginType", PluginLoader.PluginType.UtilityExtension)]
    class Main : RuleDefinitionPluginBase
    {
        public override void Execute()
        {
            Valid = (!PluginHelper.HasRecursiveConfiguration);
            Category = Valid ? "0" : "1";
            Name = "Recursive Workflow";
            Description = Valid ? "Recursive Configurations not detected." : "Recursive configuration detected.";
            Url = new Uri("http://blogs.msdn.com/b/sharepointdesigner/archive/2009/07/13/service-pack-2-prevents-an-on-change-workflow-from-starting-itself.aspx");
            Category = Valid ? "0" : "1";

            Parameters = new[]
            {
                new XElement("Recursion", "Recursive Workflow Detected: " + !Valid) 
            };
        }

    }
}
