using System.Windows.Forms;
using PluginManager.SupportPackage;
using SupportPackage.Controls;

namespace WorkflowAnalyzer.Tabs
{
    class FarmTopologyTab : ITabContext
    {
        public TabPage Tab { get; set; }
        public string TabTitle { get; set; }
        public Control ChildControl { get; set; }
        private FlowLayoutPanel flowLayoutPanel;

        public FarmTopologyTab(string title)
        {
            TabTitle = title;
            InitializeTab();
            InitializeChildControl();
        }

        public void InitializeTab()
        {
            Tab = new TabPage();
            Tab.Text = TabTitle;
        }

        public void InitializeChildControl()
        {
            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.AutoScroll = true;
            ChildControl = flowLayoutPanel;
            ChildControl.Dock = DockStyle.Fill;

            flowLayoutPanel.Controls.Add(new SupportPackage.Controls.FarmSummaryControl(PluginHelper.FarmSummaryContext, PluginHelper.NintexProductDataContext));

            foreach (SPServer server in PluginHelper.FarmSummaryContext.Servers)
            {
                SharePointServer spServer = new SharePointServer(server);


                flowLayoutPanel.Controls.Add(spServer);
            }

            Tab.Controls.Add(ChildControl);
        }

        public TabPage GetTabPage()
        {
            return Tab;
        }
    }
}
