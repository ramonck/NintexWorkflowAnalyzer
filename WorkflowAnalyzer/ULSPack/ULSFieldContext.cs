
using System.Collections.Generic;

namespace ULSPack
{
    public class ULSFieldContext : IULSFieldContext
    {

        public ULSFieldContext()
        {
            InitializeLists();
        }

        public List<string> TimeStamp { get; set; }
        public List<string> Process { get; set; }
        public List<string> TID { get; set; }
        public List<string> Area { get; set; }
        public List<string> Category { get; set; }
        public List<string> EventID { get; set; }
        public List<string> Level { get; set; }
        public List<string> Message { get; set; }
        public List<string> Correlation { get; set; }

        private void InitializeLists()
        {
            TimeStamp = new List<string>();
            Process = new List<string>();
            TID = new List<string>();
            Area = new List<string>();
            Category = new List<string>();
            EventID = new List<string>();
            Level = new List<string>();
            Message = new List<string>();
            Correlation = new List<string>();
        }
    }
}
