

using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class SPPatchDetail
    {
        public string Name;
        public string Version;
        public string Status;

        [XmlArrayItem("FarmPatchDetail", typeof(SPPatchDetail))]
        [XmlArray("PatchableUnits")]
        public SPPatchDetail[] PatchableUnits;
    }
}
