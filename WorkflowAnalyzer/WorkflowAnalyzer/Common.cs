using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;


namespace WorkflowAnalyzer
{
    public class Common
    {
        private Bitmap _bitmap;
        private FileTypes.FileType _fileType;
        private NWFContext _nwfContext;

        internal Common(INWFContext nwfContext)
        {
            _fileType = FileTypes.FileType.Nwf;
            _nwfContext = (NWFContext)nwfContext;
        }

        public static String ConvertXmlToHtml(String XML, String XSL)
        {
            
            XslCompiledTransform transform = new XslCompiledTransform();
            StringReader sreader = new StringReader(XML);
            XmlReader xreader = XmlReader.Create(sreader);
            StringBuilder HTML = new StringBuilder();
            XmlWriterSettings xmlwritesettings = new XmlWriterSettings();
            xmlwritesettings.ConformanceLevel = ConformanceLevel.Auto;
            XmlWriter xmlwrite = XmlWriter.Create(HTML, xmlwritesettings);
            transform.Load(XSL);
            transform.Transform(xreader, null, xmlwrite);

            return HTML.ToString();
        }

        public void SaveHtmlToFile(WebBrowser wb, String docname)
        {
            SaveFileDialog saveHtml = new SaveFileDialog();
            saveHtml.Filter = @"HTML Files (*.html)|*.html";
            saveHtml.FileName = _nwfContext.GetWorkflowConfigurationNodeListByXPath("//Title")[0].InnerText +
                                string.Format(" - {0}.html", docname);
            saveHtml.ShowDialog();

            if (saveHtml.FileName != "")
            {
                File.WriteAllText(saveHtml.FileName, wb.DocumentText);
            }

        }

        public void SaveStringToFile(String Text, String extension)
        {
            SaveFileDialog saveString = new SaveFileDialog();
            saveString.Filter = extension+" Files (*."+extension+")|*."+extension+"";
            saveString.FileName = _nwfContext.GetWorkflowConfigurationNodeListByXPath("//Title")[0].InnerText + " " + DateTime.Now.ToString("MM-dd-yy H-mm-ss");
            saveString.ShowDialog();

            if (saveString.FileName != "")
            {
                File.WriteAllText(saveString.FileName, Text);
            }
        }

        private Bitmap GetHtmlRender(String html)
        {
            WebBrowser wb = new WebBrowser();
            wb.ScrollBarsEnabled = false;
            wb.ScriptErrorsSuppressed = true;
            wb.DocumentText = html;
            while (wb.ReadyState != WebBrowserReadyState.Complete) { Application.DoEvents(); }

            wb.Width = wb.Document.Body.ScrollRectangle.Height;
            wb.Height = wb.Document.Body.ScrollRectangle.Height;

            _bitmap = new Bitmap(wb.Width, wb.Height);
            wb.DrawToBitmap(_bitmap, new Rectangle(0, 0, wb.Width, wb.Height));
            wb.Dispose();
            return _bitmap;
        }

        public void SaveImagetoFile(string viewName)
        {
            XmlNode WFGraphical = (_nwfContext.GetWorkflowConfigurationNodeListByXPath("//ExportedWorkflow")[0]);
            String staging = ConvertXmlToHtml(WFGraphical.OuterXml, "graphical.xsl");
            staging = staging.Replace(@"wfimages/", (Application.StartupPath + "\\wfimages\\"));
            SaveFileDialog saveimage = new SaveFileDialog();
            saveimage.Filter = "PNG Files (*.png)|*.png";
            saveimage.FileName = _nwfContext.GetWorkflowConfigurationNodeListByXPath("//Title")[0].InnerText + string.Format(" - {0}.png", viewName);
            saveimage.ShowDialog();

            Bitmap bm = GetHtmlRender(staging);


            if (saveimage.FileName != "")
            {
                bm.Save(saveimage.FileName, ImageFormat.Png);

            }
            if (bm != null)
            {
                bm.Dispose();
            }
            if (_bitmap != null)
            {
                _bitmap.Dispose();
            }
            GC.Collect();


        }

        public void SaveImagetoFileForPreview(string viewName)
        {
            XmlDocument previewdoc = new XmlDocument();
            previewdoc.LoadXml(_nwfContext.NWFXmlModified.ChildNodes.Item(1).FirstChild.InnerText);
            XmlNode WFGraphical = previewdoc.SelectNodes("//ExportedWorkflow")[0];

            String staging = ConvertXmlToHtml(WFGraphical.OuterXml, "graphical.xsl");
            staging = staging.Replace(@"wfimages/", (Application.StartupPath + "\\wfimages\\"));
            SaveFileDialog saveimage = new SaveFileDialog();
            saveimage.Filter = "PNG Files (*.png)|*.png";
            saveimage.FileName = _nwfContext.GetWorkflowConfigurationNodeListByXPath("//Title")[0].InnerText +
                                 string.Format(" - {0}", viewName);
            saveimage.ShowDialog();

            Bitmap bm = this.GetHtmlRender(staging);


            if (saveimage.FileName != "")
            {
                bm.Save(saveimage.FileName, ImageFormat.Png);

            }
            if (bm != null)
            {
                bm.Dispose();
            }
            if (_bitmap != null)
            {
                _bitmap.Dispose();
            }
            GC.Collect();


        }
    }
}
