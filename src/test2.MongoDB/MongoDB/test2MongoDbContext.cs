using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace test2.MongoDB;

[ConnectionStringName(test2DbProperties.ConnectionStringName)]
public class test2MongoDbContext : AbpMongoDbContext, Itest2MongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.Configuretest2();
    }
}
