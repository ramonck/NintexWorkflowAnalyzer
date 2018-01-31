using System;
using System.ComponentModel.Composition;
using System.Xml.Linq;
using PluginManager;
using PluginManager.Plugins;
using System.Collections.Generic;
using PluginManager.NWF;

namespace WorkflowAnalyzer.CallWebServiceTokenChecker
{
    [Export(typeof(IExternalExtension))]
    [ExportMetadata("PluginType", PluginLoader.PluginType.UtilityExtension)]
    public class Main : RuleDefinitionPluginBase
    {
        public override void Execute()
        {
            Valid = (PluginHelper.CallWebServiceUsesTokenEncoding);
            Category = Valid ? "0" : "1";
            Name = "Call Web Service Tokens";
            Description = Valid ? "Call Web Service Actions use Tokens when not in Builder mode." : "Call Web Service actions do not use Tokens in SOAP.";
            Url = new Uri("https://community.nintex.com");

            Parameters = new[]
            {
                new XElement("CallWebServiceToken", "Call Web Service Actions use tokens when not in Builder mode: " + Valid) 
            };
        }
    }
}
