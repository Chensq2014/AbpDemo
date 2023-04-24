using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DataProcessor.Data;

/* This is used if database provider does't define
 * IDataProcessorDbSchemaMigrator implementation.
 */
public class NullDataProcessorDbSchemaMigrator : IDataProcessorDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
