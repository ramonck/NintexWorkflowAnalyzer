using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using PluginManager;
using PluginManager.Plugins;
using WorkflowAnalyzer.VariablesTab.Properties;

namespace WorkflowAnalyzer.VariablesTab
{
    [Export(typeof(IExternalExtension))]
    public class Main : ExternalWebBrowserTabPluginBase
    {

        public override void Execute()
        {
            ExternalTabPage.Text = "Variables";

            string testing = PluginHelper.NwfXmlInternalDocument.OuterXml;

            XElement root = XElement.Parse(testing);

            IEnumerable<XElement> variable =
                from el in root.Descendants("Variable")
                where el.Attribute("Name").Value != string.Empty
                select el;

            StringBuilder sb = new StringBuilder();

            sb.Append(@"<!DOCTYPE>");
            sb.Append(@"<html>");
            sb.Append(@"<head>");
            sb.Append(@"<META http-equiv=""X-UA-Compatible"" content=""IE=10"">");
            sb.Append(PluginHelper.JQueryLibrary);
            sb.Append(Resources.JS);
            sb.Append(@"</head>");
            sb.Append(@"<body>");
            sb.AppendFormat(@"<div class=""{0}"">", "Variables");
            foreach (XElement el in variable)
            {
                sb.Append("<H3>" + el.FirstAttribute.Value + "<H3>");

                sb.AppendFormat(@"<div class=""{0}"">", "Variable");
                
                sb.AppendFormat(@"<div class=""{0}"">", "Attributes");
                foreach (XAttribute at in el.Attributes())
                {
                    sb.AppendFormat(@"<div class=""{0}"">", at.Name);
                    sb.Append(at.Name + ": " + el.Attribute(at.Name).Value);
                    sb.Append(@"</div>");
                }
                sb.Append(@"</div>");

                sb.Append(@"</div>");
            }
            sb.Append(@"</div>");
            sb.Append(@"</body>");
            sb.Append(@"</html>");
            TabBrowser.DocumentText = sb.ToString();

        }
    }
}
