using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using PluginManager;
using WorkflowAnalyzer.Properties;
using WorkflowAnalyzer.Tabs;

namespace WorkflowAnalyzer.Forms
{
    internal partial class WfaMain : Form
    {
        private PluginLoader pm = new PluginLoader();

        private TabFactory _tabFactory = new TabFactory();

        private Queue<TabPage> _tabQueue = new Queue<TabPage>();

        private NWFContext _nwfContext;

        private NFContext _nfContext;

        private FileHandler _fileHandler;

        private Common _common;
        TabControl _MainTabs = new TabControl();
        String _workflowName;
        RegExForm _regexform;
        private int xpos = Settings.Default.WFALocationX;
        private int ypos = Settings.Default.WFALocationY;

        private List<TabPage> _pluginTabs;

        public WfaMain() //Debug mode
        {
            InitializeComponent();

            SharedStartup();

            SetMenuItems(false);
        }

        private void FileExtensionHandler()
        {
            switch (_fileHandler.GetFileType()) //check code here
            {
                case FileTypes.FileType.Nwf:
                    if (_fileHandler.IsFileLoaded())
                    {
                        SetOpenMenu(false);
                        _nwfContext = _fileHandler.GetNWFContext();
                        _common = new Common(_nwfContext);
                        LoadNWFTabs();
                        SetMenuItems(true);
                    }
                    break;

                case FileTypes.FileType.Zip:
                    if (_fileHandler.IsFileLoaded())
                    {
                        SetOpenMenu(false);
                        LoadSupportPackageTabs();
                    }
                    break;

                case FileTypes.FileType.Log:
                    if (_fileHandler.IsFileLoaded())
                    {
                        SetOpenMenu(false);
                        LoadLogFileTabs();
                    }
                    break;

                case FileTypes.FileType.Xml:
                    if (_fileHandler.IsFileLoaded())
                    {
                        _nfContext = _fileHandler.GetNFContext();
                        SetOpenMenu(false);
                        LoadNFTabs();
                    }
                    break;

                case FileTypes.FileType.None:
                    break;
            }

            SharedStartup();
        }

        /// <summary>
        /// OneClick Installation
        /// </summary>
        /// <param name="args"></param>
        public WfaMain(String[] args)
        {
            InitializeComponent();
            
            try

            {
                 args = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData;
                 //MessageBox.Show("AttachDebugger");
                if (args != null)
                {
                    _fileHandler = new FileHandler();
                    _fileHandler.OpenFile(new Uri(args[0]).LocalPath);

                    FileExtensionHandler();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        } //File Association mode

        private void SharedStartup()
        {
            saveWorkflowPreviewToolStripMenuItem.Enabled = false;
            SystemWrapper.SetBrowserFeatureControl();
            AddTabControls();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fileHandler = new FileHandler();

            _fileHandler.OpenFileDialog();
            
            FileExtensionHandler();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Version version = Version.Parse(Application.ProductVersion);
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) 
            {
                System.Deployment.Application.ApplicationDeployment ad = System.Deployment.Application.ApplicationDeployment.CurrentDeployment;
                version = ad.CurrentVersion;
            }
            MessageBox.Show(Application.ProductName + Environment.NewLine + Resources.WfaMain_aboutToolStripMenuItem_Click_Version__ + version + Environment.NewLine, Resources.WfaMain_aboutToolStripMenuItem_Click_Nintex_Workflow_Analyzer);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetFormTitleNWF() //need to add to debug context
        {
            Text = Resources.WfaMain_LoadMainBrowserWithContent_Nintex_Workflow_Analyzer___ + PluginHelper.WorkflowTitle;
        }

        private void SetFormTitleSupportPackage()
        {
            Text = "Nintex Workflow Analyzer - Support Package";
        }

        private void SetFormTitleLogFile()
        {
            Text = "Nintex Workflow Analyzer - Log File";
        }

        private void EnqueueTab(ITabContext context)
        {
            _tabQueue.Enqueue(_tabFactory.NewTab(context));
        }

        private void LoadTabPlugins(List<TabPage> tabsList )
        {
            _pluginTabs = tabsList;

            foreach (TabPage tab in _pluginTabs)
            {
                _MainTabs.Controls.Add(tab);
            }
        }

        private void AddTabControls()
        {
            MainPanel.Controls.Add(_MainTabs);
            _MainTabs.Dock = DockStyle.Fill;
        }

        private void LoadNWFTabs()
        {
            EnqueueTab(new GraphicalTab(_nwfContext, "Graphical View"));

            //Tab removed until it can be refactored to use WPF instead. Severe performance issues.
            //EnqueueTab(new GraphicalTabV2("Graphical View V2"));
            EnqueueTab(new ActionTab(_nwfContext, "Actions"));
            EnqueueTab(new VariablesTab(_nwfContext, "Variables"));
            EnqueueTab(new ParametersTab(_nwfContext, "Parameters"));
            EnqueueTab(new ExternalRefsTab(_nwfContext, "External References"));
            EnqueueTab(new BpaTab(_nwfContext, pm, "Best Practices Analyzer"));
            EnqueueTab(new EditorTab(_nwfContext, "Editor"));

            pm.InitializeExternalTabPlugins();
            LoadTabPlugins(pm.TabPages);

            ProcessTabQueue();

            SetFormTitleNWF();
        }

        private void LoadNFTabs()
        {
            EnqueueTab(new GraphicalFormsTab(_nfContext, "Graphical View"));
            ProcessTabQueue();
        }

        private void LoadSupportPackageTabs()
        {
            SetFormTitleSupportPackage();
            EnqueueTab(new WebFarmSummaryTab("Farm Summary"));
            EnqueueTab(new WebNintexProductsTab("Nintex Products"));
            EnqueueTab(new FarmTopologyTab("Farm Topology"));
            

            if (PluginHelper.NintexProductDataContext.NintexWorkflowInfo != null && !string.IsNullOrEmpty(PluginHelper.NintexProductDataContext.NintexWorkflowInfo.NWFFile))
            {
                _nwfContext = new NWFContext(PluginHelper.NintexProductDataContext.NintexWorkflowInfo.NWFFile);
                EnqueueTab(new ULSTab("ULS Log - Workflow Instance"));
                LoadNWFTabs();
            }

            pm.InitializeExternalTabPlugins();
            LoadTabPlugins(pm.TabPages);


            ProcessTabQueue();
        }

        private void LoadLogFileTabs()
        {
            SetFormTitleLogFile();

            EnqueueTab(new ULSTab("SharePoint ULS Log File"));

            pm.InitializeExternalTabPlugins();
            LoadTabPlugins(pm.TabPages);

            ProcessTabQueue();
        }

        private void saveGraphicalViewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _common.SaveImagetoFile("GraphicalView");
        }

        private void saveActionViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActionTab actionTab = new ActionTab(_nwfContext, "Action");

            WebBrowser browser = actionTab.Browser;

            _common.SaveHtmlToFile(browser, "Action");
        }

        private void saveVariablesViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariablesTab variablesTab = new VariablesTab(_nwfContext, "Variables");

            WebBrowser browser = variablesTab.Browser;

            _common.SaveHtmlToFile(browser, "Variables");
        }

        private void saveWorkflowConfigurationViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParametersTab parametersTab = new ParametersTab(_nwfContext, "Parameters");

            WebBrowser browser = parametersTab.Browser;

            _common.SaveHtmlToFile(browser, "Parameters");
        }

        private void saveExternalReferencesViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExternalRefsTab externalRefsTab = new ExternalRefsTab(_nwfContext, "ExternalRefs");

            WebBrowser browser = externalRefsTab.Browser;

            _common.SaveHtmlToFile(browser, "ExternalRefs");
        }

        private void savePossibleIssuesViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BpaTab bpaTab = new BpaTab(_nwfContext, pm , "Bpa");

            WebBrowser browser = bpaTab.Browser;

            _common.SaveHtmlToFile(browser, "Bpa");
        }

        private void saveWorkflowPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _common.SaveImagetoFileForPreview("XMLEditorPreview");
        }

        private void regularExpressionToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _regexform = new RegExForm();
            _regexform.Show();
        }

        private void installToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.AddExtension = true;
            dialog.AutoUpgradeEnabled = true;
            dialog.CheckFileExists = true;
            dialog.CheckPathExists = true;
            dialog.DefaultExt = "dll";
            dialog.Filter = @"Dll files (*.dll)|*.dll|All files (*.*)|*.*";
            dialog.Multiselect = true;
            dialog.FileOk += delegate
            {
                int i = 0;
                foreach (string filename in dialog.FileNames)
                {
                    File.Copy(filename, Application.StartupPath + @"\\Plugins\\" + dialog.SafeFileNames[i], true);
                    i++;
                }
            };

            dialog.ShowDialog();
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\\Plugins\\");
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;

            if (Settings.Default.RememberWindowLocations & xpos != 0 & ypos != 0)
            {
                    Location = new Point(xpos, ypos);
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
            Settings.Default.Upgrade();
        }

        private void SetOpenMenu(bool toggle)
        {
            if (openToolStripMenuItem.GetCurrentParent().InvokeRequired)
            {
                openToolStripMenuItem.GetCurrentParent().Invoke((MethodInvoker)delegate
                {
                    openToolStripMenuItem.Visible = toggle;
                });
            }
            openToolStripMenuItem.Visible = toggle;

        }

        private void SetMenuItems(bool toggle)
        {
            saveGraphicalViewToolStripMenuItem.Enabled = toggle;
            saveExternalConfigurationViewToolStripMenuItem.Enabled = toggle;
            saveMainViewToolStripMenuItem.Enabled = toggle;
            savePossibleIssuesViewToolStripMenuItem.Enabled = toggle;
            saveVariablesViewToolStripMenuItem.Enabled = toggle;
            saveWorkflowConfigurationViewToolStripMenuItem.Enabled = toggle;
            //saveWorkflowPreviewToolStripMenuItem.Enabled = toggle;
        }

        private void ProcessTabQueue()
        {
                while(_tabQueue.Count > 0)
                _MainTabs.Controls.Add(_tabQueue.Dequeue());
        }

    }
}
