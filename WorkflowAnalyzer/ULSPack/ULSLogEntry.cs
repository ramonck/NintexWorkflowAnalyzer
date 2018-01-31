
namespace ULSPack
{
    public class ULSLogEntry : IULSLogEntry
    {
        public string Timestamp { get; set; }
        public string Process { get; set; }
        public string TID { get; set; }
        public string Area { get; set; }
        public string Category { get; set; }
        public string EventID { get; set; }
        public string Level { get; set; }
        public string Message { get; set; }
        public string Correlation { get; set; }

        public ULSLogEntry(string[] ulsEntry)
        {
            Timestamp = ulsEntry[0];
            Process = ulsEntry[1];
            TID = ulsEntry[2];
            Area = ulsEntry[3];
            Category = ulsEntry[4];
            EventID = ulsEntry[5];
            Level = ulsEntry[6];
            Message = ulsEntry[7];
            Correlation = ulsEntry[8];
            
        }
    }
}
