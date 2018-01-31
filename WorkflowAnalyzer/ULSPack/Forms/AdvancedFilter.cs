using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ULSPack.Forms
{
    public partial class AdvancedFilter : Form
    {
        private List<IFilterQuery> _queries; 

        public AdvancedFilter()
        {
            InitializeComponent();
            _queries = new List<IFilterQuery>();
        }

        public List<IFilterQuery> GetQueries()
        {
            return _queries;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ULSGridView.Rows)
            {
                DataGridViewComboBoxCell field = (DataGridViewComboBoxCell)row.Cells[0];
                DataGridViewComboBoxCell operation = (DataGridViewComboBoxCell)row.Cells[1];
                DataGridViewTextBoxCell query = (DataGridViewTextBoxCell) row.Cells[2];

                if (IsRowValid(row))
                {
                    ULSQuery ulsQuery = new ULSQuery(Guid.NewGuid().ToString(), query.Value.ToString(), (FilterOperators.OperationType)Enum.Parse(typeof(FilterOperators.OperationType), operation.Value.ToString()), (ColumnTypes.ColumnType)Enum.Parse(typeof(ColumnTypes.ColumnType), field.Value.ToString().Split(new[] { "Filter" }, StringSplitOptions.None)[0]));
                    _queries.Add(ulsQuery);
                }
            }
            Close();
        }

        private void Cancel_Click(object sender, System.EventArgs e)
        {
            ULSGridView.Rows.Clear();
            Close();
        }

        private bool IsRowValid(DataGridViewRow row)
        {
            bool validator = true;

            DataGridViewComboBoxCell field = (DataGridViewComboBoxCell)row.Cells[0];
            DataGridViewComboBoxCell operation = (DataGridViewComboBoxCell)row.Cells[1];
            DataGridViewTextBoxCell query = (DataGridViewTextBoxCell)row.Cells[2];

            if (field.Value == null) validator = false;
            if (operation.Value == null) validator = false;
            if (query.Value == null) validator = false;

            return validator;
        }

    }
}
