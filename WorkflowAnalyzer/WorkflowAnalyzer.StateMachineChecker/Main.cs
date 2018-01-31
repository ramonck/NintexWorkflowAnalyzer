using System;
using System.ComponentModel.Composition;
using System.Xml.Linq;
using PluginManager;
using PluginManager.Plugins;
using PluginManager.NWF;
using System.Collections.Generic;

namespace WorkflowAnalyzer.StateMachineChecker
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
            Name = "State Machine";
            Url = new Uri("http://community.nintex.com");
            PropertyBag = new Dictionary<string, object>();

            Validation();

            //Needs to be set after all validation has occured.
            Description = Valid ? "No state machine configuration issues found." : "State machine configuration issues found.";

            //Must have at least one parameter to avoid rendering issues.
            if(_params.Count == 0)
            {
                _params.Add(new XElement("PlaceHolder", ""));
            }
            Parameters = _params.ToArray();
        }

        private void Validation()
        {

            //Check presence of End Workflow action inside of a State Machine.
            var actions = PluginHelper.NintexWorkflowInternalContext.Configurations.ActionConfigs.FindAll(x => x.Type == "Nintex.Workflow.Activities.Adapters.NWStateMachine2Adapter");
            Action<NWActionConfig> EndWorkflowActionFilter = delegate (NWActionConfig action)
            {
                if (action.Type == "Nintex.Workflow.Activities.Adapters.WFTerminateAdapter")
                {
                    Valid = false;
                    //Check to ensure the parameter has not already been added.
                    if (!_params.Exists(x => x.Name == "EndWorkflow"))
                    {
                        _params.Add(new XElement("EndWorkflow", "State Machine containing an End Workflow action detected: " + !Valid));
                    }
                }
            };
            RecursiveActionSearch(EndWorkflowActionFilter, actions);

            //Check presence of Change State action configured to exit state machine.
            var smActions = PluginHelper.NintexWorkflowInternalContext.Configurations.ActionConfigs.FindAll(x => x.Type == "Nintex.Workflow.Activities.Adapters.NWStateMachine2Adapter");
            foreach (NWActionConfig smAction in smActions)
            {
                PropertyBag.Add("Exits", false);

                
                Action<NWActionConfig> EndStateMachineActionFilter = delegate (NWActionConfig action)
                {
                    if (action.Type == "Nintex.Workflow.Activities.Adapters.NWStateChangeAdapter")
                    {
                        if (action.Parameters.Exists(x => x.Name == "State" && x.PrimitiveValue != null && x.PrimitiveValue.Value == "ExitStateMachine"))
                        {
                            PropertyBag["Exits"] = true;
                        }
                    }
                };
                RecursiveActionSearch(EndStateMachineActionFilter, smAction.ChildActivities);
                if (!_params.Exists(x => x.Name == "ExitStateMachine" & !(bool)PropertyBag["Exits"]))
                {
                    Valid = false;
                    _params.Add(new XElement("ExitStateMachine", "Detected a state machine missing change state action configured to exit: " + (bool)PropertyBag["Exits"]));
                    break;
                }
            }


        }
    }
}
