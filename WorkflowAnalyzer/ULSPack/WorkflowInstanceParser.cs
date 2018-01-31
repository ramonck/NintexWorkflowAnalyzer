using System.Collections.Generic;
using System.Linq;
using SupportPackage;

namespace ULSPack
{
    public class WorkflowInstanceParser
    {
        private List<IULSLogEntry> _ulsLogEntries;
        private string _instanceId;
        public List<IULSLogEntry> ParsedUlsLogEntries { get; protected set; } 

        public WorkflowInstanceParser(List<IULSLogEntry> ulsLogEntries, string InstanceId)
        {
            _ulsLogEntries = ulsLogEntries;
            _instanceId = InstanceId;
            ParseLog();
        }

        private void ParseLog()
        {
            List<IULSLogEntry> WorkflowInstanceEntries = new List<IULSLogEntry>();
            
            //Locate Workflow Instance Entries
            WorkflowInstanceEntries = (from entry in _ulsLogEntries
                where entry.Message.Contains(_instanceId) && !string.IsNullOrEmpty(entry.Correlation)
                select entry).ToList();

            //No hits found for workflow instance Id
            if (WorkflowInstanceEntries.Count <= 0) return;

            //Locate all Entries sharing correlation Id's with Workflow Instance
            ParsedUlsLogEntries = (from entry in _ulsLogEntries
                where entry.Correlation != null && entry.Correlation.Contains(WorkflowInstanceEntries[0].Correlation)
                select entry).ToList();
        }
    }
}
