using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULSPack.FilterRules;
using ULSPack.Forms;

namespace ULSPack.Controls
{
    public partial class ULSLogEntriesGridControl : UserControl
    {
        private List<IULSLogEntry> _ulsLogEntries;

        private IULSFieldContext _ulsFieldContext = new ULSFieldContext();

        private DataGridView.HitTestInfo _logHitTestInfo;

        private Dictionary<string,ILogFilterRule> _filterRules = new Dictionary<string, ILogFilterRule>(); 

        public ULSLogEntriesGridControl(List<IULSLogEntry> ulsLogEntries)
        {
            InitializeComponent();

            _ulsLogEntries = ulsLogEntries;

            SetGridViewProperties();

            PopulateFilterLists();

            PopulateFilterControls();

            RefreshGridView();
        }

        private void SetGridViewProperties()
        {
            LogEntriesGrid.AutoSize = true;
            LogEntriesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LogEntriesGrid.ReadOnly = true;

            TimeStamp.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Process.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Thread.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Product.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EventID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Level.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Message.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Correlation.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void PopulateFilterLists()
        {
            _ulsFieldContext.TimeStamp = (from entry in _ulsLogEntries
                select entry.Timestamp).Distinct().ToList();

            _ulsFieldContext.Process = (from entry in _ulsLogEntries
                              select entry.Process).Distinct().ToList();

            _ulsFieldContext.TID = (from entry in _ulsLogEntries
                              select entry.TID).Distinct().ToList();

            _ulsFieldContext.Area = (from entry in _ulsLogEntries
                              select entry.Area).Distinct().ToList();

            _ulsFieldContext.Category = (from entry in _ulsLogEntries
                              select entry.Category).Distinct().ToList();

            _ulsFieldContext.EventID = (from entry in _ulsLogEntries
                             select entry.EventID).Distinct().ToList();

            _ulsFieldContext.Level = (from entry in _ulsLogEntries
                             select entry.Level).Distinct().ToList();

            _ulsFieldContext.Message = (from entry in _ulsLogEntries
                             select entry.Message).Distinct().ToList();

            _ulsFieldContext.Correlation = (from entry in _ulsLogEntries
                             select entry.Correlation).Distinct().ToList();
        }

        private void PopulateFilterControls()
        {
            SetComboBoxConfiguration(ProcessFilter, _ulsFieldContext.Process);
            SetComboBoxConfiguration(CategoryFilter, _ulsFieldContext.Category);
            SetComboBoxConfiguration(LevelFilter, _ulsFieldContext.Level);
            SetComboBoxConfiguration(CorrelationFilter, _ulsFieldContext.Correlation);
        }

        private void SetComboBoxConfiguration(ToolStripComboBox comboBox, List<string> filterList)
        {
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox.AutoCompleteCustomSource = getAutoCompleteStringCollectionFromList(filterList);

            //Remove any potential null values.
            filterList.RemoveAll(item => item == null);

            comboBox.Items.AddRange(filterList.ToArray());
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            Graphics graphics = CreateGraphics();

            comboBox.DropDownWidth = (int)graphics.MeasureString(filterList.OrderByDescending(entry => entry.Length).First(), comboBox.Font).Width + SystemInformation.VerticalScrollBarWidth + 10;
        }

        private AutoCompleteStringCollection getAutoCompleteStringCollectionFromList(List<string> list)
        {
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();

            foreach (string entry in list)
            {
                autoCompleteStringCollection.Add(entry);
            }

            return autoCompleteStringCollection;
        }

        public async void RefreshGridView()
        {
            LogEntriesGrid.Rows.Clear();

            await Task.Run(delegate
            {
                foreach (IULSLogEntry entry in _ulsLogEntries)
                {
                    bool validated = true;

                    foreach (ILogFilterRule filter in _filterRules.Values)
                    {
                        filter.ResetValidator();
                        filter.SetUlsEntry(entry);
                        filter.Initialize();
                        if (!filter.Validated()) validated = false;
                    }

                    if (validated) AddEntryToGridViewSafe(entry);
                }
            });


            
        }

        //Thread safe
        private void AddEntryToGridViewSafe(IULSLogEntry entry)
        {
            if (LogEntriesGrid.InvokeRequired)
            {
                LogEntriesGrid.Invoke((MethodInvoker) delegate
                {
                    AddEntryToGridView(entry);
                });
            }
            else
            {
                AddEntryToGridView(entry);
            }
            
        }

        //Not thread safe
        private void AddEntryToGridView(IULSLogEntry entry)
        {
            LogEntriesGrid.Rows.Add(entry.Timestamp, entry.Process, entry.TID, entry.Area, entry.Category,
                    entry.EventID, entry.Level, entry.Message, entry.Correlation);
        }

        private void ResetFiltering_Click(object sender, EventArgs e)
        {
            _filterRules.Clear();
            RefreshGridView();
        }

        private void CheckExistingFilter(string FilterName)
        {
            if (_filterRules.ContainsKey(FilterName)) _filterRules.Remove(FilterName);
        }

        private void AddFilterToFilterRules(string query, string filterName, ILogFilterRule filter)
        {
            filter.SetFilterName(filterName);
            CheckExistingFilter(filter.GetFilterName());
            filter.SetQuery(query);
            _filterRules.Add(filter.GetFilterName(), filter);
        }

        private void AddFilterToFilterRules(IFilterQuery query)
        {
            ULSQuery ulsQuery = (ULSQuery) query;

            CheckExistingFilter(ulsQuery.FilterName);

            _filterRules.Add(ulsQuery.FilterName, new TemplateFilter(query));
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            AddFilterToFilterRules(SearchTextbox.Text, "SearchFilter", new SearchFilter());
            RefreshGridView();
        }

        private void LogEntriesGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            _logHitTestInfo = LogEntriesGrid.HitTest(e.X, e.Y);
        }

        private void ULSLogEntriesGridControl_Load(object sender, EventArgs e)
        {
            LogEntriesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LogEntriesGrid.MultiSelect = false;

            LogEntriesGrid.CellContentDoubleClick += delegate
            {
                DataGridViewRow row = LogEntriesGrid.Rows[_logHitTestInfo.RowIndex];

                List<string> ulsEntry = new List<string>();

                foreach (DataGridViewCell cell in row.Cells)
                {
                    ulsEntry.Add(cell.Value.ToString());
                }

                EntryDetail detailForm = new EntryDetail(new ULSLogEntry(ulsEntry.ToArray()));
                detailForm.Show();
            };
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox control = (ToolStripComboBox)sender;

            ColumnTypes.ColumnType columnType = (ColumnTypes.ColumnType)Enum.Parse(typeof(ColumnTypes.ColumnType), control.Name.Split(new[] { "Filter" }, StringSplitOptions.None)[0]);

            ULSQuery logQuery = new ULSQuery(control.Name, control.SelectedItem.ToString(), FilterOperators.OperationType.Contains, columnType);

            AddFilterToFilterRules(logQuery);

            RefreshGridView();
        }

        private void AdvancedQueryButton_Click(object sender, EventArgs e)
        {
            AdvancedFilter filterform = new AdvancedFilter();
            filterform.FormClosing += filterform_FormClosing;
            filterform.ShowDialog();
        }

        void filterform_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdvancedFilter filterform = (AdvancedFilter) sender;

            foreach (IFilterQuery query in filterform.GetQueries())
            {
                AddFilterToFilterRules(query);
            }
            RefreshGridView();
        }

    }
}
