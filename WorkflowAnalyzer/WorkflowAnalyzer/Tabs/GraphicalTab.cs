using System.Windows.Forms;
using System.Xml;

namespace WorkflowAnalyzer.Tabs
{
    internal class GraphicalTab : WebTabBase
    {
        internal GraphicalTab(NWFContext nwfContext, string tabTitle)
        {
            TabTitle = tabTitle;

            InitializeTab();

            GetBrowserDocument(nwfContext.GetWorkflowConfigurationNodeListByXPath("//ExportedWorkflow")[0]);

            InitializeChildControl();
        }

        private void GetBrowserDocument(XmlNode node)
        {

            if (node != null)
            {
                string staging = Common.ConvertXmlToHtml(node.OuterXml, "graphical.xsl");

                SetBrowserText(staging.Replace(@"wfimages/", (Application.StartupPath + "\\wfimages\\")));
            }
            else
            {
                SetBrowserText("Content Failed to load. :(");
            }
        }
    }
}
