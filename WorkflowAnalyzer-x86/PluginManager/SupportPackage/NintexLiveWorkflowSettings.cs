using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class NintexLiveWorkflowSettings
    {
        [XmlElement("IsLiveEnabled")]
        public bool IsLiveEnabled;

        [XmlElement("AllowLiveCatalogInDesigner")]
        public bool AllowLiveCatalogInDesigner;

        [XmlElement("AllowViewCommentsAndRatings")]
        public bool AllowViewCommentsAndRatings;

        [XmlElement("AllowRatingsAndComments")]
        public bool AllowRatingsAndComments;

    }
}
