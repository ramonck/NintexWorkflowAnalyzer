using System;
using System.ComponentModel.Composition;
using System.Xml.Linq;
using PluginManager;
using PluginManager.Plugins;

namespace WorkflowAnalyzer.ActionCounter
{
    [Export(typeof(IExternalExtension))]
    [ExportMetadata("PluginType", PluginLoader.PluginType.UtilityExtension)]
    class Main : RuleDefinitionPluginBase
    {
        public override void Execute()
        {
            Valid = (PluginHelper.ActionCount < 100);
            Category = Valid ? "0" : "1";
            Name = "Action Count";
            Description = Valid ? "Action count in workflow is within limits." : "Action count in workflow could cause performance issues.";
            Url = new Uri("https://community.nintex.com/community/build-your-own/blog/2014/12/02/defensive-workflow-design-part-3-separation-of-concerns");

            Parameters = new[]
            {
                new XElement("ActionCount", "Workflow Action Count: " + PluginHelper.ActionCount) 
            };
        }
    }
}
