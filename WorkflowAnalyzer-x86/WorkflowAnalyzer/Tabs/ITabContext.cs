
using System.Windows.Forms;

namespace WorkflowAnalyzer.Tabs
{
    public interface ITabContext
    {
        TabPage Tab { get; set; }
        string TabTitle { get; set; }
        Control ChildControl { get; set; }

        void InitializeTab();
        void InitializeChildControl();
        TabPage GetTabPage();
    }
}
