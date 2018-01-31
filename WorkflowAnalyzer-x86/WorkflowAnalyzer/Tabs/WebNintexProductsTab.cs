
namespace WorkflowAnalyzer.Tabs
{
    internal class WebNintexProductsTab : WebTabBase
    {
        internal WebNintexProductsTab(string tabTitle)
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
                SetBrowserText(Common.ConvertXmlToHtml(PluginHelper.NintexProductsXmlDocument.InnerXml, "defaultss.xsl"));
            }
            else
            {
                SetBrowserText("Content Failed to load. :(");
            }
        }
    }
}
