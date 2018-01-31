using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using ULSPack.FilterRules;
using ULSPack.Forms;
using Xceed.Wpf.DataGrid;

namespace ULSPack.Controls
{
    public partial class ULSLogEntriesGridControlV2 : UserControl
    {
        Xceed.Wpf.DataGrid.DataGridControl control = new DataGridControl();

        private DataTable _table = new DataTable();

        private object _lock = new object();

        private object _filterlock = new object();

        private List<IULSLogEntry> _ulsLogEntries;

        private IULSFieldContext _ulsFieldContext = new ULSFieldContext();

        private IInputElement _logHitTestInfo;

        private Dictionary<string,ILogFilterRule> _filterRules = new Dictionary<string, ILogFilterRule>(); 

        public ULSLogEntriesGridControlV2(List<IULSLogEntry> ulsLogEntries)
        {
            InitializeComponent();

            WpfAdapter.Child = control;

            _ulsLogEntries = ulsLogEntries;

            SetTableColumns();

            PopulateFilterLists();

            PopulateFilterControls();

            BackgroundWorker worker = new BackgroundWorker();

            worker.DoWork += delegate
            {
                RefreshGridView();
            };
            worker.RunWorkerCompleted += delegate
            {
                lock (_lock)
                {
                    control.ItemsSource = new DataGridCollectionView(_table.DefaultView);
                }
            };

            worker.RunWorkerAsync();
        }

        private void SetTableColumns()
        {
            string[] columnTitles = { "TimeStamp", "Process", "Thread", "Product", "Category", "EventId", "Level", "Message", "Correlation" };

            lock (_lock)
            {
                foreach (string columnTitle in columnTitles)
                {
                    _table.Columns.Add(new DataColumn(columnTitle, typeof (string)));
                }
            }
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
            comboBox.Items.Insert(0, string.Empty);
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
            lock (_lock)
            {
                _table.Rows.Clear();
            }
            await Task.Run(delegate
            {
                foreach (IULSLogEntry entry in _ulsLogEntries)
                {
                    bool validated = true;

                    lock (_filterlock)
                    {
                        foreach (ILogFilterRule filter in _filterRules.Values)
                        {
                            filter.ResetValidator();
                            filter.SetUlsEntry(entry);
                            filter.Initialize();
                            if (!filter.Validated()) validated = false;
                        }
                    }
                    if (validated) AddEntryToTable(entry);
                }
            }); 
        }

        private void AddEntryToTable(IULSLogEntry entry)
        {
            lock (_lock)
            {
                System.Data.DataRow row = _table.NewRow();

                row["TimeStamp"] = entry.Timestamp;
                row["Process"] = entry.Process;
                row["Thread"] = entry.TID;
                row["Product"] = entry.Area;
                row["Category"] = entry.Category;
                row["EventId"] = entry.EventID;
                row["Level"] = entry.Level;
                row["Message"] = entry.Message;
                row["Correlation"] = entry.Correlation;

                _table.Rows.Add(row);
            }
        }

        private void ResetFiltering_Click(object sender, EventArgs e)
        {
            lock (_filterlock)
            {
                _filterRules.Clear();
            }

            ProcessFilter.SelectedIndex = 0;
            CategoryFilter.SelectedIndex = 0;
            LevelFilter.SelectedIndex = 0;
            CorrelationFilter.SelectedIndex = 0;
            SearchTextbox.Text = string.Empty;

            RefreshGridView();
        }

        private void CheckExistingFilter(string FilterName)
        {
            lock (_filterlock)
            {
                if (_filterRules.ContainsKey(FilterName)) _filterRules.Remove(FilterName);
            }
        }

        private void AddFilterToFilterRules(string query, string filterName, ILogFilterRule filter)
        {
            filter.SetFilterName(filterName);
            CheckExistingFilter(filter.GetFilterName());
            filter.SetQuery(query);
            lock (_filterlock)
            {
                _filterRules.Add(filter.GetFilterName(), filter);
            }
        }

        private void AddFilterToFilterRules(IFilterQuery query)
        {
            ULSQuery ulsQuery = (ULSQuery) query;

            CheckExistingFilter(ulsQuery.FilterName);

            lock (_filterlock)
            {
                _filterRules.Add(ulsQuery.FilterName, new TemplateFilter(query));
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchAll();
        }

        private void SearchAll()
        {
            AddFilterToFilterRules(SearchTextbox.Text, "SearchFilter", new SearchFilter());
            RefreshGridView();
        }

        private void LogEntriesGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if(Mouse.LeftButton != MouseButtonState.Pressed)
            _logHitTestInfo = control.InputHitTest(new System.Windows.Point(System.Windows.Forms.Cursor.Position.X, System.Windows.Forms.Cursor.Position.Y));
        }

        private void ULSLogEntriesGridControl_Load(object sender, EventArgs e)
        {
            //LogEntriesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //LogEntriesGrid.MultiSelect = false;

            control.MouseDoubleClick += LogEntriesGrid_MouseDoubleClick;

            control.MouseDoubleClick += delegate
            {
                System.Data.DataRow row = ((System.Data.DataRowView)control.SelectedItem).Row;

                List<string> ulsEntry = new List<string>();

                
                foreach (string value in row.ItemArray)
                {
                    ulsEntry.Add(value);
                }

                EntryDetail detailForm = new EntryDetail(new ULSLogEntry(ulsEntry.ToArray()));
                detailForm.Show();
            };

            control.SelectionChanged += control_SelectionChanged;
        }

        void control_SelectionChanged(object sender, DataGridSelectionChangedEventArgs e)
        {
            if (GetSelectedRow() != null)
            {
                try
                {
                    MessagePreviewTextbox.Text = GetSelectedRow()[7].ToString();
                }
                catch
                {
                    MessagePreviewTextbox.Text = string.Empty;
                }
                
            }
            else
            {
                MessagePreviewTextbox.Text = string.Empty;
            }
            
        }

        private System.Data.DataRow GetSelectedRow()
        {
            if (control.SelectedItem != null)
                return ((System.Data.DataRowView)control.SelectedItem).Row;
            return null;
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

        private void SearchTextbox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter)
            {
                SearchAll();
            }
        }

    }
}
