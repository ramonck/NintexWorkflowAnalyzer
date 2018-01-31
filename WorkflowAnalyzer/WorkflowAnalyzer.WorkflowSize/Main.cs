using System;
using System.ComponentModel.Composition;
using System.Xml.Linq;
using PluginManager;
using PluginManager.Plugins;

namespace WorkflowAnalyzer.WorkflowSize
{
    [Export(typeof(IExternalExtension))]
    [ExportMetadata("PluginType", PluginLoader.PluginType.UtilityExtension)]
    class Main : RuleDefinitionPluginBase
    {
        public override void Execute()
        {
            Valid = (PluginHelper.WorkflowSize < 500);
            Name = "Workflow Size";
            Description = Valid ? "File size is within limits." : "Workflow is over the recommended size.";
            Url = new Uri("https://community.nintex.com/community/build-your-own/blog/2014/12/02/defensive-workflow-design-part-3-separation-of-concerns");
            Category = Valid ? "0" : "2";

            Parameters = new[]
            {
                new XElement("WorkflowSize", "Workflow File Size: " + PluginHelper.WorkflowSize + "Kb") 
            };
        }
    }
}
