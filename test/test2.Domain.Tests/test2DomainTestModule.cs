using Volo.Abp.Modularity;

namespace test2;

[DependsOn(
    typeof(test2DomainModule),
    typeof(test2TestBaseModule)
)]
public class test2DomainTestModule : AbpModule
{

}
