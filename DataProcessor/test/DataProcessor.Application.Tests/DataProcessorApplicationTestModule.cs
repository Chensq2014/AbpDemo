using Volo.Abp.Modularity;

namespace DataProcessor;

[DependsOn(
    typeof(DataProcessorApplicationModule),
    typeof(DataProcessorDomainTestModule)
    )]
public class DataProcessorApplicationTestModule : AbpModule
{

}
