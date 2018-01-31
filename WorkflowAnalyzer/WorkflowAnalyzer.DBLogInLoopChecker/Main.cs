using System;
using System.ComponentModel.Composition;
using System.Xml.Linq;
using PluginManager;
using PluginManager.Plugins;
using System.Collections.Generic;
using PluginManager.NWF;

namespace WorkflowAnalyzer.DBLogInLoopChecker
{
    [Export(typeof(IExternalExtension))]
    [ExportMetadata("PluginType", PluginLoader.PluginType.UtilityExtension)]
    class Main : RuleDefinitionPluginBase
    {
        public override void Execute()
        {
            Valid = (!PluginHelper.IsLoggingProgressDataInLoop);
            Category = Valid ? "0" : "1";
            Name = "Progress Data Logged in Loop";
            Description = Valid ? "Progress Data is not being logged within a Loop." : "Progress Data is being logged within a loop action.";
            Url = new Uri("https://community.nintex.com");

            Parameters = new[]
            {
                new XElement("DBLogInLoop", "Nested Log Actions Detected: " + !Valid) 
            };
        }

    }
}
