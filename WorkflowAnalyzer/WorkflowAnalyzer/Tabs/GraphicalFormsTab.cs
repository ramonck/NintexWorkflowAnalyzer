using PluginManager;
using PluginManager.NF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WorkflowAnalyzer.Forms;
using WorkflowAnalyzer.Properties;

namespace WorkflowAnalyzer.Tabs
{
    
    internal class GraphicalFormsTab : WebTabBase
    {
        private FormsInterop _interop { get; set; }

        internal GraphicalFormsTab(NFContext nfcommon, string tabTitle)
        {
            TabTitle = tabTitle;

            InitializeTab();

            //Edit this to match document!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            GetBrowserDocument(nfcommon.NFXmlDocument);

            CheckBrowser();

            Panel panel = new Panel();
            
            Browser.Dock = DockStyle.Fill;
            panel.Controls.Add(Browser);

            ChildControl = panel;

            ChildControl.Dock = DockStyle.Fill;
            Tab.Controls.Add(ChildControl);

            _interop = new FormsInterop(nfcommon);
            Browser.ObjectForScripting = _interop;
        }

        private void GetBrowserDocument(XmlNode node)
        {
            if (node != null)
            {
                String staging = Common.ConvertXmlToHtml(PluginHelper.NfXmlDocument.InnerXml, "Forms.xsl");
                staging = staging.Replace(@"nfimages/", (Application.StartupPath + "\\nfimages\\"));
                string assets = Resources.Forms_Assets.Replace("{Assets}", Application.StartupPath + "\\assets\\");
                SetBrowserText(staging.Replace(@"{Assets}", assets));
            }
            else
            {
                SetBrowserText("Content Failed to load. :(");
            }
        }
    }

    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public class FormsInterop
    {
        private NFContext _context { get; set; }

        internal FormsInterop(NFContext context)
        {
            _context = context;
        }

        public void ShowConfig(string controlId){
            FormControlProperties prop = PluginHelper.NintexFormsContext.FormControls.Where(c => c.UniqueId == controlId).First();

            FormControlConfiguration form = new FormControlConfiguration(prop);

            form.Show();
        }


    }
}
