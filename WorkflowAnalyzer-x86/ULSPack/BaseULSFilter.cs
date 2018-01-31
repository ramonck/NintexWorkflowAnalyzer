using System;


namespace ULSPack
{
    public abstract class BaseULSFilter : ILogFilterRule
    {
        protected internal bool Validator = true;
        protected internal string QueryString;
        protected internal IULSLogEntry Entry;
        protected internal string FilterName;
        protected internal IFilterQuery Query;
        protected internal FilterOperators.OperationType Operation;


        public bool Validated()
        {
            return Validator;
        }

        public virtual void Initialize()
        {
            throw new NotImplementedException();
        }

        public void ResetValidator()
        {
            Validator = true;
        }

        public void SetQuery(string queryString)
        {
            QueryString = queryString;
        }

        public void SetUlsEntry(IULSLogEntry entry)
        {
            Entry = entry;
        }

        public string GetFilterName()
        {
            if (string.IsNullOrEmpty(FilterName)) throw new NotImplementedException();
            return FilterName;
        }

        public void SetFilterName(string filterName)
        {
            FilterName = filterName;
        }

        public void SetQueryObject(IFilterQuery query)
        {
            Query = query;
        }
    }
}
