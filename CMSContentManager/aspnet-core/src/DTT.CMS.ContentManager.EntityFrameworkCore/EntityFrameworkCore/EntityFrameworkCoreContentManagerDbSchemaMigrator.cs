using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DTT.CMS.ContentManager.Data;
using Volo.Abp.DependencyInjection;

namespace DTT.CMS.ContentManager.EntityFrameworkCore;

public class EntityFrameworkCoreContentManagerDbSchemaMigrator
    : IContentManagerDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreContentManagerDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ContentManagerDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ContentManagerDbContext>()
            .Database
            .MigrateAsync();
    }
}
