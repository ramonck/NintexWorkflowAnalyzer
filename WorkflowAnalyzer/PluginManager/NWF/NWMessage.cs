
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PluginManager.NWF
{
    public class NWMessage
    {
        [XmlElement("Priority")]
        public string Priority;

        [XmlElement("ExcludeHeaderAndFooter")]
        public bool ExcludeHeaderAndFooter;

        [XmlArrayItem("MessageAttachment", typeof(MessageAttachment))]
        [XmlArray("Attachments")]
        public List<MessageAttachment> Attachments;

        [XmlElement("IsUsingGroupMessage")]
        public bool IsUsingGroupMessage;

        [XmlElement("AllowLazyApprove")]
        public bool AllowLazyApprove;

        [XmlElement("Options")]
        public ApprovalOptions Options;

        [XmlElement("Body")]
        public string Body;

        [XmlElement("Subject")]
        public string Subject;
        
        [XmlElement("From")]
        public ApproverFrom From;

        [XmlArray("CcList")] 
        [XmlArrayItem("User", typeof (User))] 
        public List<User> CcList;

        [XmlArray("BcList")]
        [XmlArrayItem("User", typeof(User))]
        public List<User> BcList;
        
        [XmlElement("AttachFile")]
        public bool AttachFile;

        [XmlElement("IsHtmlMessage")]
        public bool IsHtmlMessage;

        [XmlElement("DeliveryType")]
        public string DeliveryType;
        
    }
}
