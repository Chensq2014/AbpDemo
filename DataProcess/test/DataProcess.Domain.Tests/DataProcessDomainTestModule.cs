using DataProcess.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DataProcess;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(DataProcessEntityFrameworkCoreTestModule)
    )]
public class DataProcessDomainTestModule : AbpModule
{

}
