
namespace SupportPackage
{
    public interface IMoreInfoControlContext
    {

        void Initialize();

        void Initialize(PluginManager.SupportPackage.FarmSummary farmSummary, PluginManager.SupportPackage.NintexProductData nintexProductData);

        void Execute();

        void Cleanup();
    }
}
