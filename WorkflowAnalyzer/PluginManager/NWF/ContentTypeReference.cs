
using System.Xml.Serialization;

namespace PluginManager.NWF
{
    public class ContentTypeReference
    {
        [XmlElement("Id")]
        public string Id;

        [XmlElement("Name")]
        public string Name;
    }
}
