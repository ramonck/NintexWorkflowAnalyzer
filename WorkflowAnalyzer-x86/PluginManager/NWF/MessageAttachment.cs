
using System.Xml.Serialization;

namespace PluginManager.NWF
{
    public class MessageAttachment
    {
        [XmlAttribute("Id")]
        public int Id;

        [XmlAttribute("Source")]
        public string Source;

        [XmlAttribute("FileName")]
        public string FileName;

        [XmlAttribute("Type")]
        public string Type;

        [XmlAttribute("MimeContentType")]
        public string MimeContentType;

    }
}
