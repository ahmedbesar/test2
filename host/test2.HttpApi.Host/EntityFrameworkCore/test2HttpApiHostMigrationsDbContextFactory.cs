using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace test2.EntityFrameworkCore;

public class test2HttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<test2HttpApiHostMigrationsDbContext>
{
    public test2HttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<test2HttpApiHostMigrationsDbContext>()
            .UseNpgsql(configuration.GetConnectionString("test2"));

        return new test2HttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
