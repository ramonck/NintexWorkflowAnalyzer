
namespace ULSPack
{
    public interface IFilterQuery
    {
        string QueryString { get; set; }
        FilterOperators.OperationType Operation { get; set; }
        ColumnTypes.ColumnType QueryColumnType { get; set; }

        void Initialize();

        void SetQueryString(string query);

        void SetFilterName(string filterName);

        void SetOperation(FilterOperators.OperationType operationType);

        void SetColumnType(ColumnTypes.ColumnType columnType);
    }
}
