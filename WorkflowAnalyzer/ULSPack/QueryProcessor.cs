
using System.Text.RegularExpressions;

namespace ULSPack
{
    public class QueryProcessor : IQueryProcessor
    {
        private bool _isValid = true;

        public QueryProcessor(string input, string query, FilterOperators.OperationType operationType)
        {
            if (input == null) return;

            switch (operationType)
            {
                case FilterOperators.OperationType.Contains:
                    if (!input.Contains(query)) _isValid = false;
                    break;

                case FilterOperators.OperationType.NotContains:
                    if (input.Contains(query)) _isValid = false;
                    break;

                case FilterOperators.OperationType.Equals:
                    if (input != query) _isValid = false;
                    break;

                case FilterOperators.OperationType.NotEquals:
                    if (input == query) _isValid = false;
                    break;

                case FilterOperators.OperationType.RegexMatch:
                    if (!Regex.IsMatch(input, query)) _isValid = false;
                    break;
            }
        }

        public bool IsValid()
        {
            return _isValid;
        }
    }
}
