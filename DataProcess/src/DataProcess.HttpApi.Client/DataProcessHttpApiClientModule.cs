using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace DataProcess;

[DependsOn(
    typeof(DataProcessApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class DataProcessHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(DataProcessApplicationContractsModule).Assembly,
            DataProcessRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<DataProcessHttpApiClientModule>();
        });

    }
}
