
using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    
    public class NintexSettings
    {
        [XmlElement("NintexWorkflowSettings")] 
        public NintexWorkflowSettings WorkflowSettings;

        [XmlElement("NintexFormsSettings")] 
        public NintexFormsSettings FormsSettings;

        [XmlElement("NintexWorkflow4PSSettings")] 
        public NintexWorkflow4PSSettings NintexWorkflow4PsSettings;
    }
}
