
using System.Xml.Serialization;

namespace PluginManager.NWF
{
    public class NWOutcome
    {
        [XmlAttribute("Id")] 
        public int Id;

        [XmlAttribute("Name")]
        public string Name;

        [XmlAttribute("CommentsMode")]
        public string CommentsMode;

        [XmlAttribute("Description")]
        public string Description;

        [XmlAttribute("BranchIndex")]
        public int BranchIndex;
    }
}
