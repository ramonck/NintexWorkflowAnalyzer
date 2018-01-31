
namespace ULSPack
{
    public interface IULSLogEntry
    {
        string Timestamp { get; set; }
        string Process { get; set; }
        string TID { get; set; }
        string Area { get; set; }
        string Category { get; set; }
        string EventID { get; set; }
        string Level { get; set; }
        string Message { get; set; }
        string Correlation { get; set; }

    }
}
