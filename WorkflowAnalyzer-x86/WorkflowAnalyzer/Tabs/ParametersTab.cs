

using System.Xml;

namespace WorkflowAnalyzer.Tabs
{
    internal class ParametersTab : WebTabBase
    {
        internal ParametersTab(NWFContext nwfContext, string tabTitle)
        {
            TabTitle = tabTitle;

            InitializeTab();

            SetBrowserDocument(nwfContext.GetWorkflowConfigurationNodeListByXPath("//NWActionConfig")[0]);

            InitializeChildControl();
        }

        internal static string GetTabRendering(NWFContext nwfContext)
        {
            return
                GetRenderedBrowserText(
                    nwfContext.GetWorkflowConfigurationNodeListByXPath("//NWActionConfig")[0].OuterXml);

        }

        private void SetBrowserDocument(XmlNode node)
        {
            if (node != null)
            {
                SetBrowserText(GetRenderedBrowserText(node.OuterXml));
            }
            else
            {
                SetBrowserText("Content Failed to load. :(");
            }
        }
    }
}
