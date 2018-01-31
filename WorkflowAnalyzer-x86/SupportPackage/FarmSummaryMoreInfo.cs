using PluginManager.SupportPackage;
using SupportPackage.Forms;

namespace SupportPackage
{
    public class FarmSummaryMoreInfo : IMoreInfoControlContext
    {
        private FarmSummary _farmSummary;
        private NintexProductData _nintexProductData;

        public void Initialize()
        {
            throw new System.NotImplementedException();
        }

        public void Initialize(FarmSummary farmSummary, NintexProductData nintexProductData)
        {
            _farmSummary = farmSummary;
            _nintexProductData = nintexProductData;
        }

        public void Execute()
        {
            FarmSummaryForm frm = new FarmSummaryForm(_farmSummary, _nintexProductData);
            frm.Show();
        }

        public void Cleanup()
        {
            
        }
    }
}
