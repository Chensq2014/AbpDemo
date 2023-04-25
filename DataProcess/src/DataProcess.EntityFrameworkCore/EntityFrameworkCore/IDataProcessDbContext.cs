using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace DataProcess.EntityFrameworkCore;

[ConnectionStringName(DataProcessDbProperties.ConnectionStringName)]
public interface IDataProcessDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
