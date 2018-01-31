
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class SPServer
    {
        public string ServerName;
        public string SharePointProductInstalled;

        [XmlArrayItem("FarmServiceDetail", typeof(SPService))]
        [XmlArray("Services")]
        public List<SPService> Services;
        public string Status;

        [XmlArrayItem("FarmPatchDetail", typeof (SPPatchDetail))]
        [XmlArray("PatchStatus")] 
        public List<SPPatchDetail> PatchStatus;
    }
}
