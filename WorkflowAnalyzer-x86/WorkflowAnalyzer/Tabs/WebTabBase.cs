

using System.Windows.Forms;

namespace WorkflowAnalyzer.Tabs
{
    class WebTabBase : ITabContext
    {
        public TabPage Tab { get; set; }

        public string TabTitle { get; set; }

        public Control ChildControl { get; set; }

        public WebBrowser Browser { get; protected set; }

        protected static string GetRenderedBrowserText(string xml)
        {
            return Common.ConvertXmlToHtml(xml, "defaultss.xsl");
        }

        public void InitializeTab()
        {
            Tab = new TabPage();
            Tab.Text = TabTitle;
        }

        public void InitializeChildControl()
        {
            CheckBrowser();
            ChildControl = Browser;
            ChildControl.Dock = DockStyle.Fill;
            Tab.Controls.Add(ChildControl);
        }

        public TabPage GetTabPage()
        {
            return Tab;
        }

        protected void CheckBrowser()
        {
            if (Browser == null)Browser = new WebBrowser();
        }

        public void SetBrowserText(string text)
        {
            CheckBrowser();
            Browser.DocumentText = text;
        }
    }
}
