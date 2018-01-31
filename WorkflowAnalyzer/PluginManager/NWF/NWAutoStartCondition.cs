using System.Xml.Serialization;

namespace PluginManager.NWF
{
    //[XmlRoot(ElementName = "AutoStartCondition", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]

    [XmlInclude(typeof(ExpressionCondition))]
    public abstract class NWAutoStartCondition
    {

    }

    public class ExpressionCondition : NWAutoStartCondition
    {
        [XmlAttribute("Operator")]
        public string Operator;

        [XmlElement("Operand1")]
        public Operand Operand1;

        [XmlElement("Compare")]
        public string Compare;

        [XmlElement("Operand2")]
        public Operand Operand2;
    }
     
}
