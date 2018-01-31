
using System.Xml.Serialization;

namespace PluginManager.SupportPackage
{
    public class NintexEmailSettings
    {
        [XmlElement("SmtpServer")]
        public string SmtpServer;

        [XmlElement("FromAddress")]
        public string FromAddress;

        [XmlElement("ReplyToAddress")]
        public string ReplyToAddress;

        [XmlElement("OutgoingEmailCharSet")]
        public string OutgoingEmailCharSet;

        [XmlElement("OutgoingPlainTextCharSet")]
        public string OutgoingPlainTextCharSet;

        [XmlElement("OutgoingSMSCharSet")]
        public string OutgoingSMSCharSet;

        [XmlElement("UseCSSInEmail")]
        public string UseCSSInEmail;

        [XmlElement("EmailStyleSheetUrl")]
        public string EmailStyleSheetUrl;


    }
}
