
using System.Xml.Serialization;

namespace PluginManager.NWF
{
    public class NWVariable
    {
        [XmlAttribute("Name")] 
        public string Name;

        [XmlAttribute("Required")] 
        public bool Required;

        [XmlAttribute("StartupOptionsConfigured")] 
        public bool StartupOptionsConfigured;

        [XmlAttribute("ControlType")] 
        public string ControlType;

        [XmlAttribute("Type")] 
        public string Type;

        [XmlAttribute("Initiate")] 
        public bool Initiate;

        [XmlAttribute("DefaultValue")] 
        public string DefaultValue;

        [XmlAttribute("Description")] 
        public string Description;

        [XmlAttribute("Direction")] 
        public string Direction;

        [XmlAttribute("RowIndex")] 
        public int RowIndex;
    }
}
