using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WorkflowAnalyzer.Tabs
{
    class ExternalRefsTab : WebTabBase
    {
        internal ExternalRefsTab(NWFContext nwfContext, string tabTitle)
        {
            TabTitle = tabTitle;

            InitializeTab();

            GetBrowserDocument(nwfContext.GetNWFNodeListByXPath("/ExportedWorkflowWithListMetdata/*[position()>1]"));

            InitializeChildControl();
        }

        private void GetBrowserDocument(XmlNodeList nodelist)
        {

            if (nodelist != null)
            {
                XmlDocument wfConfiguration = new XmlDocument();
                StringBuilder wfConfigBuilder = new StringBuilder();

                wfConfigBuilder.Append("<WorkflowExternalConfiguration>");

                foreach (XmlNode wfnode in nodelist)
                {
                    wfConfigBuilder.Append(wfnode.OuterXml);
                }

                wfConfigBuilder.Append("</WorkflowExternalConfiguration>");

                wfConfiguration.LoadXml(wfConfigBuilder.ToString());

                string staging = Common.ConvertXmlToHtml(wfConfiguration.OuterXml, "defaultss.xsl");
                SetBrowserText(staging.Replace(@"wfimages/", (Application.StartupPath + "\\wfimages\\")));

            }
            else
            {
                SetBrowserText("Content Failed to load. :(");
            }
        }
    }
}
