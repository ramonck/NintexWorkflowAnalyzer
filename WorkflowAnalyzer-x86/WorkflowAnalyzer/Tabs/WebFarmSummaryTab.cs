
namespace WorkflowAnalyzer.Tabs
{
    internal class WebFarmSummaryTab : WebTabBase
    {
        internal WebFarmSummaryTab(string tabTitle)
        {
            TabTitle = tabTitle;

            InitializeTab();

            GetBrowserDocument();

            InitializeChildControl();
        }

        private void GetBrowserDocument()
        {

            if (PluginHelper.FarmSummaryXmlDocument != null)
            {
                SetBrowserText(Common.ConvertXmlToHtml(PluginHelper.FarmSummaryXmlDocument.InnerXml, "defaultss.xsl"));
            }
            else
            {
                SetBrowserText("Content Failed to load. :(");
            }
        }
    }
}
