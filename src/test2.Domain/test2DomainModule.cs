using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace test2;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(test2DomainSharedModule)
)]
    public class test2DomainModule : AbpModule
{

}
