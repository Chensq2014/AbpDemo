using System.Threading.Tasks;

namespace DataProcessor.Data;

public interface IDataProcessorDbSchemaMigrator
{
    Task MigrateAsync();
}
