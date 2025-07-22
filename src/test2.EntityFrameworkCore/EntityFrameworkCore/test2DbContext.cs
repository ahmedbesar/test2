using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace test2.EntityFrameworkCore;

[ConnectionStringName(test2DbProperties.ConnectionStringName)]
public class test2DbContext : AbpDbContext<test2DbContext>, Itest2DbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public test2DbContext(DbContextOptions<test2DbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Configuretest2();
    }
}
