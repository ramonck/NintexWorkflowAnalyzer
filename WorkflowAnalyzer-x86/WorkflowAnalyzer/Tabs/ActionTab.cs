

using System.Xml;

namespace WorkflowAnalyzer.Tabs
{
    internal class ActionTab : WebTabBase
    {
        internal ActionTab(NWFContext nwfContext, string tabTitle)
        {
            TabTitle = tabTitle;

            InitializeTab();

            GetBrowserDocument(nwfContext.NWFXmlDocument.ChildNodes.Item(1));

            InitializeChildControl();
        }

        private void GetBrowserDocument(XmlNode node)
        {

            if (node != null)
            {
                SetBrowserText(Common.ConvertXmlToHtml(node.FirstChild.InnerText, "defaultss.xsl"));
            }
            else
            {
                SetBrowserText("Content Failed to load. :(");
            }
        }
    }
}
