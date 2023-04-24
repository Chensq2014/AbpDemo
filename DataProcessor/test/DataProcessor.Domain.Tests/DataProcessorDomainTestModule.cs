using DataProcessor.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DataProcessor;

[DependsOn(
    typeof(DataProcessorEntityFrameworkCoreTestModule)
    )]
public class DataProcessorDomainTestModule : AbpModule
{

}
