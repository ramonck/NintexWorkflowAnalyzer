
namespace ULSPack
{
    public class ULSQuery : BaseFilterQuery
    {
        public ULSQuery()
        {
            
        }

        public ULSQuery(string filterName, string query, FilterOperators.OperationType operationType, ColumnTypes.ColumnType columnType)
        {
            SetFilterName(filterName);
            SetQueryString(query);
            SetOperation(operationType);
            SetColumnType(columnType);
        }
    }
}
