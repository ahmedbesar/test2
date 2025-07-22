using test2.Samples;
using Xunit;

namespace test2.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<test2MongoDbTestModule>
{

}
