using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TWO.Data;

/* This is used if database provider does't define
 * ITWODbSchemaMigrator implementation.
 */
public class NullTWODbSchemaMigrator : ITWODbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
