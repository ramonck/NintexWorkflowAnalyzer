namespace ULSPack.FilterRules
{
    public class SearchFilter : BaseULSFilter
    {
        public override void Initialize()
        {

            if (string.IsNullOrEmpty(QueryString)) return;

            bool isValid = false;

            QueryString = QueryString.ToLower();

            if (Entry.Area.ToLower().Contains(QueryString)) isValid = true;
            if (Entry.Category.ToLower().Contains(QueryString)) isValid = true;
            if (Entry.Correlation.ToLower().Contains(QueryString)) isValid = true;
            if (Entry.EventID.ToLower().Contains(QueryString)) isValid = true;
            if (Entry.Level.ToLower().Contains(QueryString)) isValid = true;
            if (Entry.Message.ToLower().Contains(QueryString)) isValid = true;
            if (Entry.Process.ToLower().Contains(QueryString)) isValid = true;
            if (Entry.TID.ToLower().Contains(QueryString)) isValid = true;

            Validator = isValid;
        }
    }
}
