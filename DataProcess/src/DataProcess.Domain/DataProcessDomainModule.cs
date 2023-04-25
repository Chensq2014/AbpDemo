using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace DataProcess;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(DataProcessDomainSharedModule)
)]
public class DataProcessDomainModule : AbpModule
{

}
