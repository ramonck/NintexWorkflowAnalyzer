
namespace ULSPack
{
    public abstract class BaseFilterQuery : IFilterQuery
    {
        public string QueryString { get; internal protected set; }

        public string FilterName { get; internal protected set; }

        string IFilterQuery.QueryString
        {
            get { return QueryString; }
            set { QueryString = value; }
        }

        public FilterOperators.OperationType Operation { get; set; }

        public ColumnTypes.ColumnType QueryColumnType { get; set; }

        public virtual void Initialize(string queryString, FilterOperators.OperationType operation, ColumnTypes.ColumnType columnType, string filterName)
        {
            QueryString = queryString;
            Operation = operation;
            QueryColumnType = columnType;
            FilterName = filterName;
        }

        public virtual void Initialize()
        {
            
        }

        public virtual void SetQueryString(string query)
        {
            QueryString = query;
        }

        public virtual void SetFilterName(string filterName)
        {
            FilterName = filterName;
        }

        public void SetOperation(FilterOperators.OperationType operation)
        {
            Operation = operation;
        }

        public void SetColumnType(ColumnTypes.ColumnType columnType)
        {
            QueryColumnType = columnType;
        }
    }
}
