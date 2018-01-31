using System;
using System.ComponentModel.Composition;
using System.Xml.Linq;
using PluginManager;
using PluginManager.Plugins;
using System.Collections.Generic;
using PluginManager.NWF;

namespace WorkflowAnalyzer.NestedLogInLoopChecker
{
    [Export(typeof(IExternalExtension))]
    [ExportMetadata("PluginType", PluginLoader.PluginType.UtilityExtension)]
    class Main : RuleDefinitionPluginBase
    {
        public override void Execute()
        {
            Valid = (!PluginHelper.HasLogNestedInLoop);
            Category = Valid ? "0" : "1";
            Name = "Nested Log";
            Description = Valid ? "No nested logs detected." : "Log nested in Loop action detected.";
            Url = new Uri("https://community.nintex.com/community/build-your-own/blog/2014/10/13/defensive-workflow-design-part-1-workflow-history-lists");

            Parameters = new[]
            {
                new XElement("NestedLog", "Nested Log Actions Detected: " + !Valid) 
            };
        }

    }
}
