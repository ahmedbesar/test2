using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace test2.MongoDB;

[ConnectionStringName(test2DbProperties.ConnectionStringName)]
public interface Itest2MongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
