using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace test2.EntityFrameworkCore;

[ConnectionStringName(test2DbProperties.ConnectionStringName)]
public interface Itest2DbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
