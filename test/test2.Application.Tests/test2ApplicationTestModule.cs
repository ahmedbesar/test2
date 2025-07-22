using Volo.Abp.Modularity;

namespace test2;

[DependsOn(
    typeof(test2ApplicationModule),
    typeof(test2DomainTestModule)
    )]
public class test2ApplicationTestModule : AbpModule
{

}
