using System;
using System.ComponentModel.Composition;
using System.Xml.Linq;
using PluginManager;
using PluginManager.Plugins;
using System.Collections.Generic;
using PluginManager.NWF;

namespace WorkflowAnalyzer.StoredCredentialChecker
{
    [Export(typeof(IExternalExtension))]
    [ExportMetadata("PluginType", PluginLoader.PluginType.UtilityExtension)]
    public class Main : RuleDefinitionPluginBase
    {
        public override void Execute()
        {
            Valid = (PluginHelper.UsingStoredCredentials);
            Category = Valid ? "0" : "1";
            Name = "Stored Credentials";
            Description = Valid ? "Workflow stores credentials securely." : "Workflow Credentials are not stored securely.";
            Url = new Uri("https://community.nintex.com/community/build-your-own/blog/2014/05/12/best-practice-for-workflow-design-using-workflow-constants");

            Parameters = new[]
            {
                new XElement("StoredCredentials", "Credentials Stored Securely: " + Valid) 
            };
        }
    }
}
