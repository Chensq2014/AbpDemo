using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace DataProcess;

[DependsOn(
    typeof(DataProcessDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class DataProcessApplicationContractsModule : AbpModule
{

}
