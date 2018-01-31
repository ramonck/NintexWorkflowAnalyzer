
using System.Windows.Forms;
using WorkflowAnalyzer.Tabs;

namespace WorkflowAnalyzer
{
    public class TabFactory
    {
        public TabPage NewTab(ITabContext context)
        {
            return context.GetTabPage();
        }
    }
}
