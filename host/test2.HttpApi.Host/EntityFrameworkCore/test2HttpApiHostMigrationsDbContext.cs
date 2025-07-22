using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace test2.EntityFrameworkCore;

public class test2HttpApiHostMigrationsDbContext : AbpDbContext<test2HttpApiHostMigrationsDbContext>
{
    public test2HttpApiHostMigrationsDbContext(DbContextOptions<test2HttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Configuretest2();
    }
}
