using test2.MongoDB;
using test2.Samples;
using Xunit;

namespace test2.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<test2MongoDbTestModule>
{

}
