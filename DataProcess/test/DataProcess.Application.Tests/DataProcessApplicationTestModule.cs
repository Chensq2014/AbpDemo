using Volo.Abp.Modularity;

namespace DataProcess;

[DependsOn(
    typeof(DataProcessApplicationModule),
    typeof(DataProcessDomainTestModule)
    )]
public class DataProcessApplicationTestModule : AbpModule
{

}
