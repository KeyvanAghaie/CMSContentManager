using Volo.Abp.Modularity;

namespace DTT.CMS.ContentManager;

/* Inherit from this class for your domain layer tests. */
public abstract class ContentManagerDomainTestBase<TStartupModule> : ContentManagerTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
