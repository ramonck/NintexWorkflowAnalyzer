using PluginManager.NF;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WorkflowAnalyzer
{
    public class NFContext
    {
        private string _nfDocument;
        public XmlDocument NFXmlDocument { get; set; }
        public NintexFormsDocument NFDocument { get; set; }

        internal NFContext(string nfDocument)
        {
            _nfDocument = nfDocument;
            ExtractXmlDocument();
            NFObjectLoader();
            PopulatePluginHelper();
        }

        private void ExtractXmlDocument()
        {
            NFXmlDocument = new XmlDocument();

            _nfDocument = _nfDocument.Replace(" xmlns:d2p1=\"http://schemas.datacontract.org/2004/07/Nintex.Forms.FormControls\"", "");

            _nfDocument = _nfDocument.Replace("d2p1:", "");

            _nfDocument = _nfDocument.Replace(" xmlns:d2p1=\"http://schemas.datacontract.org/2004/07/Nintex.Forms.SharePoint.FormControls\"", "");

            _nfDocument = _nfDocument.Replace("xmlns:d3p1=\"http://schemas.datacontract.org/2004/07/Nintex.Forms.SharePoint.FormControls\" ", "");

            _nfDocument = _nfDocument.Replace("xmlns:d3p1=\"http://schemas.datacontract.org/2004/07/Nintex.Forms.SharePoint.FormControls._properties\" ", "");

            _nfDocument = _nfDocument.Replace("d3p1:", "");

            _nfDocument = _nfDocument.Replace(" xmlns:d2p1=\"http://schemas.microsoft.com/2003/10/Serialization/Arrays\"", "");

            _nfDocument = _nfDocument.Replace(" xmlns:d4p1=\"http://schemas.datacontract.org/2004/07/Microsoft.SharePoint.WebControls\"", "");

            _nfDocument = _nfDocument.Replace(" xmlns:d4p1=\"http://schemas.microsoft.com/2003/10/Serialization/Arrays\"", "");

            _nfDocument = _nfDocument.Replace("d4p1:", "");

            _nfDocument = _nfDocument.Replace(" xmlns=\"http://schemas.datacontract.org/2004/07/Nintex.Forms\"", "");

            _nfDocument = _nfDocument.Replace("FormControlProperties i:type=", "FormControlProperties type=");

            //_nfDocument = _nfDocument.Replace("xmlns:i=\"http://www.w3.org/2001/XMLSchema-instance\"", "");

            NFXmlDocument.LoadXml(_nfDocument.Replace(Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble()), ""));
            PluginHelper.NfXmlDocument = NFXmlDocument;
        }

        private void PopulatePluginHelper()
        {
            PluginHelper.NintexFormsContext = NFDocument;
        }

        private void NFObjectLoader()
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                NFXmlDocument.Save(memoryStream);

                memoryStream.Position = 0;

                XmlSerializer serializer = new XmlSerializer(typeof(NintexFormsDocument));

                var externalDoc = (NintexFormsDocument)serializer.Deserialize(memoryStream);

                PluginHelper.NintexFormsContext = externalDoc;

                NFDocument = externalDoc;
            }
        }
    }
}
