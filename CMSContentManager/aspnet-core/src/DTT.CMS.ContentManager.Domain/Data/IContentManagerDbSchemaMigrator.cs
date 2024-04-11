using System.Threading.Tasks;

namespace DTT.CMS.ContentManager.Data;

public interface IContentManagerDbSchemaMigrator
{
    Task MigrateAsync();
}
