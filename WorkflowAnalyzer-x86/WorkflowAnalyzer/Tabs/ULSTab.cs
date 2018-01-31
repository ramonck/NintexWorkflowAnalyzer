using System.Windows.Forms;
using ULSPack;
using ULSPack.Controls;
using Label = System.Windows.Forms.Label;

namespace WorkflowAnalyzer.Tabs
{
    public class ULSTab : ITabContext
    {
        public TabPage Tab { get; set; }
        public string TabTitle { get; set; }
        public Control ChildControl { get; set; }
        private FlowLayoutPanel _flowLayoutPanel;

        public ULSTab(string title)
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
            ULSLogEntriesGridControlV2 grid;

            if (PluginHelper.NintexProductDataContext != null &&
                PluginHelper.NintexProductDataContext.NintexWorkflowInfo != null)
            {
                WorkflowInstanceParser parser = new WorkflowInstanceParser(PluginHelper.UlsLogEntries,
                    PluginHelper.NintexProductDataContext.NintexWorkflowInfo.WorkflowInstanceId);

                if (parser.ParsedUlsLogEntries == null)
                {
                    MissingWorkflowHandler();
                    return;
                }

                grid = new ULSLogEntriesGridControlV2(parser.ParsedUlsLogEntries);
            }
            else
            {
                grid = new ULSLogEntriesGridControlV2(PluginHelper.UlsLogEntries);
            }

            grid.Dock = DockStyle.Fill;
            ChildControl = grid;
            Tab.AutoScroll = true;
            Tab.Controls.Add(ChildControl);
        }

        public TabPage GetTabPage()
        {
            return Tab;
        }

        private void MissingWorkflowHandler()
        {
                Label label = new Label();
                label.AutoSize = true;

                label.Text = "No Workflow log entries found.";
                _flowLayoutPanel.Controls.Add(label);
                Tab.Controls.Add(ChildControl);
        }
    }
}
