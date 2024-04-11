using Volo.Abp.Modularity;

namespace DTT.CMS.ContentManager;

public abstract class ContentManagerApplicationTestBase<TStartupModule> : ContentManagerTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
