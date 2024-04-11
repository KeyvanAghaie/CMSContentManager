using Volo.Abp.Modularity;

namespace DTT.CMS.ContentManager;

[DependsOn(
    typeof(ContentManagerApplicationModule),
    typeof(ContentManagerDomainTestModule)
)]
public class ContentManagerApplicationTestModule : AbpModule
{

}
