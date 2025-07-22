using Volo.Abp.Modularity;

namespace test2;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class test2DomainTestBase<TStartupModule> : test2TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
