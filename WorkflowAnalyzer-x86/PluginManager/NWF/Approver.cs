using System.Xml.Serialization;

namespace PluginManager.NWF
{
    public class Approver
    {
        [XmlAttribute("PrincipalType")]
        public string PrincipalType;

        [XmlAttribute("User")]
        public string User;

        [XmlAttribute("AllowDelegation")]
        public bool AllowDelegation;

        [XmlAttribute("IsCustom")]
        public bool IsCustom;

        [XmlAttribute("AllowLazyApprove")]
        public bool AllowLazyApprove;

        [XmlAttribute("DisplayName")]
        public string DisplayName;

        [XmlElement("ApprovalRequiredMsg")]
        public NWMessage ApprovalRequiredMsg;

        [XmlElement("ApprovalNotRequiredMsg")]
        public NWMessage ApprovalNotRequiredMsg;
    }
}
