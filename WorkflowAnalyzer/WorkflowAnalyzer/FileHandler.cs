using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using PluginManager.NWF;
using PluginManager.SupportPackage;
using ULSPack;
using WorkflowAnalyzer.Properties;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleToAttribute("WFAInterop")]

namespace WorkflowAnalyzer
{
    public class FileHandler
    {
        private bool _isFileLoaded;
        private FileTypes.FileType _fileType;
        private NWFContext _nwfContext;
        private NFContext _nfContext;

        /// <summary>
        /// Launches Open File Dialog Modal Window.
        /// </summary>
        internal void OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Settings.Default.FilePathMemory;
            openFileDialog.Filter = @"Nintex Workflow Files (*.nwf)|*.nwf|Nintex Forms Files (*.xml)|*.xml|Support Package Files (*.zip)|*.zip|SharePoint Log File (*.log)|*.log";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string extension = Regex.Replace(openFileDialog.SafeFileName, @"(.*)(\.)(\w*)", "$3").ToLower();

                    switch (extension)
                    {
                        case "nwf":
                            NwfFileLoader(openFileDialog.FileName);
                            break;
                        case "xml":
                            NfFileLoader(openFileDialog.FileName);
                            break;
                        case "zip":
                            SupportPackageLoader(openFileDialog.FileName);
                            break;
                        case "log":
                            LogFileLoader(openFileDialog.FileName);
                            break;
                        default:
                            _isFileLoaded = false;
                            _fileType = FileTypes.FileType.None;
                            break;
                    }

                    AfterFileLoad(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"File Loader Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        internal void OpenFile(string filePath)
        {
            try
            {
                string extension = Regex.Replace(filePath, @"(.*)(\.)(\w*)", "$3").ToLower();

                switch (extension)
                {
                    case "nwf":
                        NwfFileLoader(filePath);
                        break;
                    case "zip":
                        SupportPackageLoader(filePath);
                        break;
                    case "log":
                        LogFileLoader(filePath);
                        break;
                    default:
                        _isFileLoaded = false;
                        _fileType = FileTypes.FileType.None;
                        break;
                }

                AfterFileLoad(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        internal FileTypes.FileType GetFileType()
        {
            return _fileType;
        }

        internal bool IsFileLoaded()
        {
            return _isFileLoaded;
        }

        internal NWFContext GetNWFContext() //Need to refactor to return an interface for support packages or NWFContext
        {
            if (_nwfContext != null)
            {
                return _nwfContext;
            }
            return null;
        }

        internal NFContext GetNFContext()
        {
            if (_nfContext != null)
            {
                return _nfContext;
            }
            return null;
        }

        /// <summary>
        /// Loads NWF File into Analyzer from provided path.
        /// </summary>
        /// <param name="fileName">Path to file including filename.</param>
        internal NWFContext NwfFileLoader(string fileName)
        {
            try
            {
                StreamReader doc = File.OpenText(fileName);

                String reader = doc.ReadToEnd();

                _nwfContext = new NWFContext(reader);

                doc.Close();

                _isFileLoaded = true;

                _fileType = FileTypes.FileType.Nwf;

                //NWFObjectLoader();

                return _nwfContext;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"NWF Context File Error: Could not read file from disk. Original error: " + ex.Message);
                return null;
            }

        }

        /// <summary>
        /// Loads NWF File into Analyzer from XML
        /// </summary>
        /// <param name="fileName">Workflow XML.</param>
        internal NWFContext NWFXMLLoader(string workflowXML)
        {
            try
            {
                
                _nwfContext = new NWFContext(workflowXML);

                _isFileLoaded = true;

                _fileType = FileTypes.FileType.Nwf;

                //NWFObjectLoader();

                return _nwfContext;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"NWF XML File Loader Error: Could not read file from disk. Original error: " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Loads Support Package File into Analyzer from provided path.
        /// </summary>
        /// <param name="fileName">Path to file including filename.</param>
        internal void SupportPackageLoader(string fileName)
        {
            using (ZipArchive packageArchive = ZipFile.Open(fileName, ZipArchiveMode.Read))
            {
                Stream farmSummaryEntry = packageArchive.GetEntry("FarmSummary.xml").Open();

                if (farmSummaryEntry == null) return;

                Stream nintexProductsEntry = packageArchive.GetEntry("NintexProducts.xml").Open();

                if (nintexProductsEntry == null) return;

                Stream ulsLogsEntry = packageArchive.GetEntry("ULSLogs.log").Open();

                if (ulsLogsEntry == null) return;

                using (StreamReader reader = new StreamReader(farmSummaryEntry, Encoding.Unicode))
                {
                    XmlDocument xmlDocument = new XmlDocument();

                    xmlDocument.LoadXml(reader.ReadToEnd());
                    PluginHelper.FarmSummaryXmlDocument = xmlDocument;

                    MemoryStream memoryStream = new MemoryStream();

                    xmlDocument.Save(memoryStream);

                    memoryStream.Position = 0;

                    XmlSerializer serializer = new XmlSerializer(typeof(FarmSummary));
                    PluginHelper.FarmSummaryContext = (FarmSummary)serializer.Deserialize(memoryStream);
                }

                using (StreamReader reader = new StreamReader(nintexProductsEntry, Encoding.Unicode))
                {
                    XmlDocument xmlDocument = new XmlDocument();

                    xmlDocument.LoadXml(reader.ReadToEnd());

                    PluginHelper.NintexProductsXmlDocument = xmlDocument;

                    MemoryStream memoryStream = new MemoryStream();

                    xmlDocument.Save(memoryStream);

                    memoryStream.Position = 0;

                    XmlSerializer serializer = new XmlSerializer(typeof(NintexProductData));

                    PluginHelper.NintexProductDataContext = (NintexProductData)serializer.Deserialize(memoryStream);

                }

                using (StreamReader reader = new StreamReader(ulsLogsEntry))
                {
                    PluginHelper.ULSLogs = reader.ReadToEnd();

                    new UlsEntryListGenerator(PluginHelper.ULSLogs);
                }
            }

            _isFileLoaded = true;
            _fileType = FileTypes.FileType.Zip;

            //Only run if the package contains workflow data.
            if (PluginHelper.NintexProductDataContext.NintexWorkflowInfo != null && !string.IsNullOrEmpty(PluginHelper.NintexProductDataContext.NintexWorkflowInfo.NWFFile))
            {
                _nwfContext = new NWFContext(PluginHelper.NintexProductDataContext.NintexWorkflowInfo.NWFFile);
            }

            //if (_nwfContext != null)
                //NWFObjectLoader();

            
        }

        internal NFContext NfFileLoader(string fileName)
        {
            try
            {
                //StreamReader doc = File.OpenText(fileName);

                //String reader = doc.ReadToEnd();

                String reader = File.ReadAllText(fileName, Encoding.Unicode);

                _nfContext = new NFContext(reader);

                //doc.Close();

                _isFileLoaded = true;

                _fileType = FileTypes.FileType.Xml;

                return _nfContext;
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"NFFileLoader Error: Could not read file from disk. Original error: " + ex.Message);
                return null;
            }
        }

        internal void LogFileLoader(string fileName)
        {
            StreamReader doc = File.OpenText(fileName);

            string reader = doc.ReadToEnd();

            new UlsEntryListGenerator(reader);

            doc.Close();

            _isFileLoaded = true;

            _fileType = FileTypes.FileType.Log;
        }

        private void AfterFileLoad(string path)
        {
            if (_isFileLoaded)
            {
                Settings.Default.FilePathMemory = Path.GetDirectoryName(path);
                Settings.Default.Save();
                Settings.Default.Upgrade();
            }
        }
                
    }
}
