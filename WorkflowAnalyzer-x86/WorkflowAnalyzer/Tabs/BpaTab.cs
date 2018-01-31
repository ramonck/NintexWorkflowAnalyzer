

using System;
using System.Windows.Forms;
using System.Xml;
using PluginManager;
using WorkflowAnalyzer.Properties;

namespace WorkflowAnalyzer.Tabs
{
    internal class BpaTab : WebTabBase
    {
        private BpaDocument _bpa;

        internal BpaTab(NWFContext nwfcommon, PluginLoader pm, string tabTitle)
        {
            TabTitle = tabTitle;

            _bpa = new BpaDocument(nwfcommon);

            InitializeTab();

            pm.InitializeRuleDefinitionPlugins();

            foreach (RuleDefinition bpaDefinition in pm.BpaDefinitions)
            {
                _bpa.AddDefinititonToBpa(bpaDefinition);
            }

            GetBrowserDocument(nwfcommon.NWFXmlDocument.ChildNodes.Item(1));

            InitializeChildControl();
        }

        private void GetBrowserDocument(XmlNode node)
        {
            if (node != null)
            {
                String staging = Common.ConvertXmlToHtml(_bpa.BpaXmlDocument.ToString(), "BPA.xsl");
                staging = staging.Replace(@"wfimages/", (Application.StartupPath + "\\wfimages\\"));
                string assets = Resources.BPA_Assets.Replace("{Assets}", Application.StartupPath + "\\assets\\");
                SetBrowserText(staging.Replace(@"{Assets}", assets));
            }
            else
            {
                SetBrowserText("Content Failed to load. :(");
            }
        }
    }
}
