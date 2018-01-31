
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PluginManager.NWF
{
    public class NWConfigurations
    {
        [XmlArrayItem("NWActionConfig", typeof(NWActionConfig))]
        [XmlArray("ActionConfigs")]
        public List<NWActionConfig> ActionConfigs;
    }
}
