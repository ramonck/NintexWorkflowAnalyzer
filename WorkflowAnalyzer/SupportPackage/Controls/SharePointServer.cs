using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PluginManager.SupportPackage;

namespace SupportPackage.Controls
{
    public partial class SharePointServer : UserControl
    {
        private bool _hasWebApp;
        private bool _hasWorkflowInfra;
        private bool _hasIncomingEmail;
        private bool _hasProjectServer;
        private bool _hasProjectServerInstalled;
        private SPServer _server;

        private List<SPService> _spServices; 

        public SharePointServer()
        {
            InitializeComponent();
        }

        public SharePointServer(SPServer server)
        {
            InitializeComponent();

            ServerName.Text = server.ServerName;
            _spServices = server.Services;
            _server = server;

            ExamineServices();
            SetServices();
            SetValidationImage();
        }

        private void ExamineServices()
        {
            if (ServiceIsOnline("Microsoft SharePoint Foundation Workflow Timer Service")) _hasWorkflowInfra = true;
            if (ServiceIsOnline("Microsoft SharePoint Foundation Web Application")) _hasWebApp = true;
            if (ServiceIsOnline("Microsoft SharePoint Foundation Incoming E-Mail")) _hasIncomingEmail = true;
            if (ServiceIsOnline("Project Server Application Service")) _hasProjectServer = true;
            if (_server.SharePointProductInstalled.Contains("Project")) _hasProjectServerInstalled = true;
        }

        private bool ServiceIsOnline(string servicename)
        {
            return _spServices.Any(x => x.Name == servicename && x.Status == "Online");
        }

        private void SetServices()
        {
            if (!_hasWebApp) WebApplication.ForeColor = Color.Silver;
            if (!_hasIncomingEmail) IncomingEmail.ForeColor = Color.Silver;
            if (!_hasProjectServer) ProjectServer.ForeColor = Color.Silver;
            if (!_hasWorkflowInfra) WorkflowInfrastructure.ForeColor = Color.Silver;
        }

        private bool ValidateServices()
        {
            if (_hasWorkflowInfra && !_hasWebApp) return false;
            if (_hasProjectServer && (!_hasWebApp || !_hasWorkflowInfra)) return false;
            if (_hasIncomingEmail && !_hasWebApp) return false;
            if (_hasProjectServerInstalled && !_hasProjectServer) return false; //Awaiting confirmation from Microsoft

            return true;
        }

        private void SetValidationImage()
        {
            if (ValidateServices())
            {
                validationControl1.SetTrue();
            }
            else
            {
                validationControl1.SetFalse();
            }
        }
    }
}
