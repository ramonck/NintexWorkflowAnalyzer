using System.Windows.Forms;

namespace ULSPack.Controls
{
    public partial class ULSEntryControl : UserControl
    {
        public ULSEntryControl(IULSLogEntry ulsLogEntry)
        {
            InitializeComponent();

            TimeStamp.Text = ulsLogEntry.Timestamp;
            Process.Text = ulsLogEntry.Process;
            TID.Text = ulsLogEntry.TID;
            Area.Text = ulsLogEntry.Area;
            Category.Text = ulsLogEntry.Category;
            EventID.Text = ulsLogEntry.EventID;
            Level.Text = ulsLogEntry.Level;
            Message.Text = ulsLogEntry.Message;
            CorrelationID.Text = ulsLogEntry.Correlation;
        }
    }
}
