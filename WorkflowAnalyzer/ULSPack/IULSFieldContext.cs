
using System.Collections.Generic;

namespace ULSPack
{
    public interface IULSFieldContext
    {
        List<string> TimeStamp { get; set; }
        List<string> Process { get; set; }
        List<string> TID { get; set; }
        List<string> Area { get; set; }
        List<string> Category { get; set; }
        List<string> EventID { get; set; }
        List<string> Level { get; set; }
        List<string> Message { get; set; }
        List<string> Correlation { get; set; }
    }
}
