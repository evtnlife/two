using System.Threading.Tasks;

namespace TWO.Data;

public interface ITWODbSchemaMigrator
{
    Task MigrateAsync();
}
