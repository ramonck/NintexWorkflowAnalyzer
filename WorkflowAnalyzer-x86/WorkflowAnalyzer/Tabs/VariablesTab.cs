

using System.Xml;

namespace WorkflowAnalyzer.Tabs
{
    internal class VariablesTab : WebTabBase
    {
        internal VariablesTab(NWFContext nwfContext, string tabTitle)
        {
            TabTitle = tabTitle;

            InitializeTab();

            GetBrowserDocument(nwfContext.GetWorkflowConfigurationNodeListByXPath("//WorkflowVariables")[0]);

            InitializeChildControl();
        }

        internal void GetBrowserDocument(XmlNode node)
        {
            if (node != null)
            {
                SetBrowserText(Common.ConvertXmlToHtml(node.OuterXml, "defaultss.xsl"));
            }
            else
            {
                SetBrowserText("Content Failed to load. :(");
            }
        }
    }
}
