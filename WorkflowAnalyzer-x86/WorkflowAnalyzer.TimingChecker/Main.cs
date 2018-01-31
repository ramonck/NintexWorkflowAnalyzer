

using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Xml.Linq;
using PluginManager;
using PluginManager.Plugins;

namespace WorkflowAnalyzer.TimingChecker
{
    [Export(typeof(IExternalExtension))]
    [ExportMetadata("PluginType", PluginLoader.PluginType.UtilityExtension)]
    class Main : RuleDefinitionPluginBase
    {
        public override void Execute()
        {
            bool valid = PluginHelper.HandlesTiming;   
            Name = "Timing Check";
            Description = valid ? "Workflow correctly handles timing." : "Workflow does not correctly handle timing.";
            Url = new Uri("https://community.nintex.com/community/build-your-own/blog/2015/03/02/defensive-workflow-design-part-4-avoiding-race-conditions");
            Valid = valid;
            Category = valid ? "0" : "1";

            List<XElement> Params = new List<XElement>();
            
                Params.Add(new XElement("Version", "Correctly handles timing: " + valid));

                if (PluginHelper.UsesEventReceiver) 
                    Params.Add(new XElement("EventReceiver", "Uses event receiver: " + PluginHelper.UsesEventReceiver));

                if (PluginHelper.StartsOnCreateEvent)
                    Params.Add(new XElement("EventReceiver", "Starts when an item is created: " + PluginHelper.StartsOnCreateEvent));

                if (PluginHelper.StartsOnCreateEvent)
                    Params.Add(new XElement("EventReceiver", "Starts when an item is modified: " + PluginHelper.StartsOnModifiedEvent));

            Parameters = Params.ToArray();

        }
    }
}
