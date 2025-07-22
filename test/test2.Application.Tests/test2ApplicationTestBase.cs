using Volo.Abp.Modularity;

namespace test2;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class test2ApplicationTestBase<TStartupModule> : test2TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
