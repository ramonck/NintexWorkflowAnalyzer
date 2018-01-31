
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PluginManager.NWF
{
    public class ListReference
    {
        [XmlArrayItem("ContentTypeReference", typeof(ContentTypeReference))]
        [XmlArray("ContentTypes")]
        public List<ContentTypeReference> ContentTypes;

        [XmlElement("IsSourceList")]
        public bool IsSourceList;

        [XmlArrayItem("FieldReference", typeof(FieldReference))]
        [XmlArray("Fields")]
        public List<FieldReference> Fields;

        [XmlElement("ListName")]
        public string ListName;

        [XmlElement("ListId")] 
        public string ListId;


    }
}
