using Volo.Abp;
using Volo.Abp.MongoDB;

namespace test2.MongoDB;

public static class test2MongoDbContextExtensions
{
    public static void Configuretest2(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
