using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DataProcess.EntityFrameworkCore;

public class DataProcessHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<DataProcessHttpApiHostMigrationsDbContext>
{
    public DataProcessHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<DataProcessHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("DataProcess"));

        return new DataProcessHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
