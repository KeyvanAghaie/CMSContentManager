using Volo.Abp.Modularity;

namespace DTT.CMS.ContentManager;

[DependsOn(
    typeof(ContentManagerDomainModule),
    typeof(ContentManagerTestBaseModule)
)]
public class ContentManagerDomainTestModule : AbpModule
{

}
