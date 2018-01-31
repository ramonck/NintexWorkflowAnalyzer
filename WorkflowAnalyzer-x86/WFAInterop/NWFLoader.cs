using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowAnalyzer;

namespace WFAInterop
{
    public class NWFLoader
    {
        FileHandler fh = new FileHandler();

        public NWFContext LoadWorkflowFile(string path)
        {
            return fh.NwfFileLoader(path);
        }

        public NWFContext LoadWorkflowXml(string workflowXml)
        {
            return fh.NWFXMLLoader(workflowXml);
        }

    }
}
