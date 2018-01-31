
namespace ULSPack
{
    public interface ILogFilterRule
    {
        bool Validated();
        void Initialize();
        void ResetValidator();
        void SetQuery(string queryString);
        void SetUlsEntry(IULSLogEntry entry);
        string GetFilterName();
        void SetFilterName(string filterName);
        void SetQueryObject(IFilterQuery query);
    }
}
