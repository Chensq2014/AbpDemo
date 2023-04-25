using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace DataProcess.EntityFrameworkCore;

public class DataProcessHttpApiHostMigrationsDbContext : AbpDbContext<DataProcessHttpApiHostMigrationsDbContext>
{
    public DataProcessHttpApiHostMigrationsDbContext(DbContextOptions<DataProcessHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureDataProcess();
    }
}
