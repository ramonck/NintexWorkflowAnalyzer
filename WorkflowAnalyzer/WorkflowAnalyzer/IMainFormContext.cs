using System.Collections.Generic;
using System.Web.UI;
using PluginManager;

namespace WorkflowAnalyzer
{
    interface IMainFormContext
    {
        PluginLoader Plugin();

        TabFactory Tabs();

        Queue<Control> TabQueue();

        NWFContext NWFileContext();

        FileHandler File();

        Common WfaCommon();

    }
}
