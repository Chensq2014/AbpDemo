using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace DataProcess;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class DataProcessInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<DataProcessInstallerModule>();
        });
    }
}
