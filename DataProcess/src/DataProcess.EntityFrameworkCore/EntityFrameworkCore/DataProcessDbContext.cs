using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace DataProcess.EntityFrameworkCore;

[ConnectionStringName(DataProcessDbProperties.ConnectionStringName)]
public class DataProcessDbContext : AbpDbContext<DataProcessDbContext>, IDataProcessDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public DataProcessDbContext(DbContextOptions<DataProcessDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureDataProcess();
    }
}
