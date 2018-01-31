
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PluginManager.NWF
{
    public class ValueStorages
    {
        [XmlArrayItem("ValueStorage", typeof(ValueStorage))]
        [XmlArray("ValueStorageItems")]
        public List<ValueStorage> ValueStorageItems;
    }
}
