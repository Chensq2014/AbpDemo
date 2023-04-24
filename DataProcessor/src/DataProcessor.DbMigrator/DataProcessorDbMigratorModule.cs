using DataProcessor.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace DataProcessor.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DataProcessorEntityFrameworkCoreModule),
    typeof(DataProcessorApplicationContractsModule)
    )]
public class DataProcessorDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
