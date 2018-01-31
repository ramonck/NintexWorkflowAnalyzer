
using System;
using System.ComponentModel.Composition;
using System.Xml.Linq;
using PluginManager;
using PluginManager.Plugins;

namespace WorkflowAnalyzer.VersionChecker
{
    [Export(typeof(IExternalExtension))]
    [ExportMetadata("PluginType", PluginLoader.PluginType.UtilityExtension)]
    class Main : RuleDefinitionPluginBase
    {
        public override void Execute()
        {
            Name = "Version Check";

            Description = Valid ? "Nintex Workflow is up to date." : "Update the Installation of Nintex Workflow.";
            Url = new Uri("https://community.nintex.com/community/installation");
            Valid = NwVersionIsCurrent();
            Parameters = new[]
            {
                new XElement("Version", "Nintex Workflow Version: " + PluginHelper.VersionOfNintexWorkflow), 
            };

            if (NwVersionIsCurrent()) Category = "0";
        }

        public Boolean NwVersionIsCurrent()
        {
            int versionOfNintexWorkflow = PluginHelper.VersionOfNintexWorkflow;

            switch (int.Parse(versionOfNintexWorkflow.ToString().Substring(0, 1)))
            {
                case 1: //NW2007
                    if (versionOfNintexWorkflow >= 11301)
                    {
                        return true;
                    }
                    break;

                case 2: //NW2010
                    if (versionOfNintexWorkflow >= 23140)
                    {
                        return true;
                    }
                    break;

                case 3: //NW2013

                    switch (versionOfNintexWorkflow)
                    {
                        case 3060: //Task Due Date issue
                            Category = "2";
                            return false;
                    }

                    if (versionOfNintexWorkflow >= 3080)
                    {
                        return true;
                    }
                    break;
            }
            Category = "1";
            return false;
        }
    }
}
