using System.Text;

namespace ULSPack.FilterRules
{
    public class TemplateFilter : BaseULSFilter
    {
        public TemplateFilter(IFilterQuery query)
        {
            SetQueryObject(query);
        }

        public TemplateFilter()
        {
            
        }

        public override void Initialize()
        {
            if (Query != null && !string.IsNullOrEmpty(Query.QueryString))
            {
                switch (Query.QueryColumnType)
                {
                    case ColumnTypes.ColumnType.All:
                        StringBuilder sb = new StringBuilder();

                        sb.Append(Entry.Area);
                        sb.Append(Entry.Category);
                        sb.Append(Entry.Correlation);
                        sb.Append(Entry.EventID);
                        sb.Append(Entry.Level);
                        sb.Append(Entry.Message);
                        sb.Append(Entry.Process);
                        sb.Append(Entry.TID);
                        sb.Append(Entry.Timestamp);

                        ExecuteQuery(sb.ToString());

                        break;

                    case ColumnTypes.ColumnType.Category:
                        ExecuteQuery(Entry.Category);
                        break;

                    case ColumnTypes.ColumnType.Correlation:
                        ExecuteQuery(Entry.Correlation);
                        break;

                    case ColumnTypes.ColumnType.EventID:
                        ExecuteQuery(Entry.EventID);
                        break;

                    case ColumnTypes.ColumnType.Level:
                        ExecuteQuery(Entry.Level);
                        break;

                    case ColumnTypes.ColumnType.Message:
                        ExecuteQuery(Entry.Message);
                        break;

                    case ColumnTypes.ColumnType.Process:
                        ExecuteQuery(Entry.Process);
                        break;

                    case ColumnTypes.ColumnType.Product:
                        ExecuteQuery(Entry.Area);
                        break;

                    case ColumnTypes.ColumnType.Thread:
                        ExecuteQuery(Entry.TID);
                        break;

                    case ColumnTypes.ColumnType.TimeStamp:
                        ExecuteQuery(Entry.Timestamp);
                        break;
                }
            }
        }

        private void ExecuteQuery(string columnText)
        {
            IQueryProcessor processor = new QueryProcessor(columnText, Query.QueryString, Query.Operation);

            Validator = processor.IsValid();
        }
    }
}
