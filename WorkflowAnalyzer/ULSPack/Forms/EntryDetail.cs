using System.Windows.Forms;

namespace ULSPack.Forms
{
    public partial class EntryDetail : Form
    {
        public EntryDetail(IULSLogEntry entry)
        {
            InitializeComponent();

            TimeStamp.Text = entry.Timestamp;
            Process.Text = entry.Process;
            TID.Text = entry.TID;
            Area.Text = entry.Area;
            Category.Text = entry.Category;
            EventID.Text = entry.EventID;
            Level.Text = entry.Level;
            Message.Text = entry.Message;
            Correlation.Text = entry.Correlation;
        }
    }
}
