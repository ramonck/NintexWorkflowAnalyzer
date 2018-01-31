using System;
using System.ComponentModel.Composition;
using System.Xml.Linq;
using PluginManager;
using PluginManager.Plugins;
using PluginManager.NWF;
using System.Collections.Generic;

namespace WorkflowAnalyzer.ParallelChecker
{
    [Export(typeof(IExternalExtension))]
    [ExportMetadata("PluginType", PluginLoader.PluginType.UtilityExtension)]
    class Main : RuleDefinitionPluginBase
    {
        List<XElement> _params = new List<XElement>();

        public override void Execute()
        {
            Valid = true;
            Category = Valid ? "0" : "1";
            Name = "Parallel Action";
            Url = new Uri("http://community.nintex.com");
            PropertyBag = new Dictionary<string, object>();

            Validation();

            //Needs to be set after all validation has occured.
            Description = Valid ? "No parallel action configuration issues found." : "Parallel action with more than three branches detected.";

            //Must have at least one parameter to avoid rendering issues.
            if (_params.Count == 0)
            {
                _params.Add(new XElement("PlaceHolder", ""));
            }
            Parameters = _params.ToArray();
        }

        private void Validation()
        {

            //Check presence of End Workflow action inside of a State Machine.
            var actions = PluginHelper.NintexWorkflowInternalContext.Configurations.ActionConfigs.FindAll(x => x.Type == "Nintex.Workflow.Activities.Adapters.WFParallelAdapter");

            foreach(NWActionConfig pAction in actions)
            {
                if (pAction.ChildActivities.FindAll(x => x.Type == "Nintex.Workflow.Activities.Adapters.WFSequenceAdapter").Count > 3)
                {
                    Valid = false;
                    _params.Add(new XElement("ParallelAction", "Detected a Parallel action with more than three branches: " + !Valid));
                    break;
                }
            }



        }
    }
}
