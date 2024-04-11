using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DTT.CMS.ContentManager.Data;

/* This is used if database provider does't define
 * IContentManagerDbSchemaMigrator implementation.
 */
public class NullContentManagerDbSchemaMigrator : IContentManagerDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
