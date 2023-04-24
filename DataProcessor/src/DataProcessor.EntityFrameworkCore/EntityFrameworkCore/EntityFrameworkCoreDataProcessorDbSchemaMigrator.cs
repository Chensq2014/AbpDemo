using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DataProcessor.Data;
using Volo.Abp.DependencyInjection;

namespace DataProcessor.EntityFrameworkCore;

public class EntityFrameworkCoreDataProcessorDbSchemaMigrator
    : IDataProcessorDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreDataProcessorDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the DataProcessorDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<DataProcessorDbContext>()
            .Database
            .MigrateAsync();
    }
}
