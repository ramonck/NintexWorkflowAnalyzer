

using System.Xml;

namespace WorkflowAnalyzer
{
    internal interface INWFXPath
    {
        XmlNodeList GetNWFNodeListByXPath(string query);

        XmlNodeList GetWorkflowConfigurationNodeListByXPath(string query);
    }
}
