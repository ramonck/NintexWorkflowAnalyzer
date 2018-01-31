using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using ULSPack;
using Xceed.Wpf.DataGrid;

namespace WorkflowAnalyzer.Forms
{
    public partial class testingwpf : Form
    {
        Xceed.Wpf.DataGrid.DataGridControl control = new DataGridControl();

        DataTable table = new DataTable();

        private List<IULSLogEntry> _ulsLogEntries;

        public testingwpf(List<IULSLogEntry> ulsLogEntries)
        {
            InitializeComponent();

            _ulsLogEntries = ulsLogEntries;

            SetTableProperties();

            BackgroundWorker worker = new BackgroundWorker();

            worker.DoWork +=worker_DoWork;

            worker.RunWorkerCompleted += worker_RunWorkerCompleted;

            worker.RunWorkerAsync();
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            control.ItemsSource = new DataGridCollectionView(table.DefaultView);
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (IULSLogEntry entry in _ulsLogEntries)
            {
                System.Data.DataRow row = table.NewRow();

                row["TimeStamp"] = entry.Timestamp;
                row["Process"] = entry.Process;
                row["Thread"] = entry.TID;
                row["Product"] = entry.Area;
                row["Category"] = entry.Category;
                row["EventId"] = entry.EventID;
                row["Level"] = entry.Level;
                row["Message"] = entry.Message;
                row["Correlation"] = entry.Correlation;

                table.Rows.Add(row);
            }
        }

        private void SetTableProperties()
        {
            string[] columnTitles = {"TimeStamp", "Process", "Thread", "Product", "Category", "EventId", "Level", "Message", "Correlation"};

            foreach (string columnTitle in columnTitles)
            {
                table.Columns.Add(new DataColumn(columnTitle, typeof (string)));
            }
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void testingwpf_Load(object sender, EventArgs e)
        {
            elementHost1.Dock = DockStyle.Fill;
            elementHost1.SizeChanged +=elementHost1_SizeChanged;
            elementHost1.Child = control;
        }

        private void elementHost1_SizeChanged(object sender, EventArgs e)
        {
            
        }
    }
}
