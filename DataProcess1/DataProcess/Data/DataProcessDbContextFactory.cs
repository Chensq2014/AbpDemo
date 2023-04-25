using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataProcess.Data;

public class DataProcessDbContextFactory : IDesignTimeDbContextFactory<DataProcessDbContext>
{
    public DataProcessDbContext CreateDbContext(string[] args)
    {

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<DataProcessDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new DataProcessDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
