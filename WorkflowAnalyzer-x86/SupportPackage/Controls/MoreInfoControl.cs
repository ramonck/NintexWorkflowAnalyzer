using System;
using System.Windows.Forms;

namespace SupportPackage.Controls
{
    public partial class MoreInfoControl : UserControl
    {
        private IMoreInfoControlContext _context;
        private PluginManager.SupportPackage.FarmSummary _farmSummary;
        private PluginManager.SupportPackage.NintexProductData _nintexProductData;

        public MoreInfoControl()
        {
            InitializeComponent();
        }

        public MoreInfoControl(IMoreInfoControlContext context, PluginManager.SupportPackage.FarmSummary farmSummary)
        {
            _context = context;
            _farmSummary = farmSummary;
        }

        public MoreInfoControl(IMoreInfoControlContext context, PluginManager.SupportPackage.FarmSummary farmSummary,
            PluginManager.SupportPackage.NintexProductData nintexProductData)
        {
            _context = context;
            _farmSummary = farmSummary;
            _nintexProductData = nintexProductData;
        }

        private void Validation_Click(object sender, EventArgs e)
        {
            if (_context == null)return;

            if (_farmSummary != null)
            {
                _context.Initialize(_farmSummary, _nintexProductData);
                _context.Execute();
                _context.Cleanup();
                return;
            }

            _context.Initialize();
            _context.Execute();
            _context.Cleanup();
        }

        public void SetContext(IMoreInfoControlContext context)
        {
            _context = context;
        }

        public void SetFarmSummary(PluginManager.SupportPackage.FarmSummary farmSummary)
        {
            _farmSummary = farmSummary;
        }

        public void SetNintexProductData(PluginManager.SupportPackage.NintexProductData nintexProductData)
        {
            _nintexProductData = nintexProductData;
        }
    }
}
