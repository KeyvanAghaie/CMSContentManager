using DTT.CMS.ContentManager.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace DTT.CMS.ContentManager.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ContentManagerEntityFrameworkCoreModule),
    typeof(ContentManagerApplicationContractsModule)
    )]
public class ContentManagerDbMigratorModule : AbpModule
{
}
