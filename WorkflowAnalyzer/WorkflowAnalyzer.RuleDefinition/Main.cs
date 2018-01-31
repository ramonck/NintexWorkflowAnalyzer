using System;
using System.ComponentModel.Composition;
using System.Xml.Linq;
using PluginManager;
using PluginManager.Plugins;

namespace WorkflowAnalyzer.RuleDefinition
{
    [Export(typeof(IExternalExtension))] //Must Export as IExternalExtension.
    class Main : RuleDefinitionPluginBase //Must inherit from PluginManager.RuleDefinitionPluginBase.
    {
        ///WorkflowAnalyzer.PluginHelper static class can be used to obtain contextual information from the loaded workflow such
        /// as NWF external and internal XML.


        /// <summary>
        /// Executes as the best practices tab is being rendered.
        /// </summary>
        public override void Execute()
        {
            Valid = true; //Indicates whether or not the rule validates.
            Name = "My Rule"; //Title of Rule.
            Description = "This is a custom rule."; //Description of rule. To follow styling, description should be set based on validation outcome.
            Url = new Uri("http://community.nintex.com"); //Url for more information on rule. Should point to a knowledgebase article or comparable document.
            Category = "0"; //Category of rule. 0 = Informational, 1 = Warning, 2 = Problematic

            Parameters = new[]
            {
                new XElement("parameter1", "My Value") //Additional parameters to be passed to the rule. 
            };
        }
    }
    
}
