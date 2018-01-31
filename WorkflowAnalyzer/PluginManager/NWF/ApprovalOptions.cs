
using System.Xml.Serialization;

namespace PluginManager.NWF
{
    public class ApprovalOptions
    {
        [XmlElement("LazyApprovalFlags")]
        public string LazyApprovalFlags;
    }
}
