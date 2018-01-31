

using System;
using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    [Serializable, XmlRoot("NintexProductData")]
    public class NintexProductData
    {
        [XmlElement("DateCreated")]
        public DateTime DateCreated;

        [XmlElement("WorkflowInfo")]
        public WorkflowInfo NintexWorkflowInfo;

        [XmlElement("Settings")] 
        public NintexSettings Settings;

        [XmlElement("LicenseInfo")] 
        public LicenseInfo License;

    }
}
