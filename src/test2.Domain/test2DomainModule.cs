using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.EventBus.RabbitMq;

namespace test2;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(test2DomainSharedModule)
)]
[DependsOn(typeof(AbpEventBusRabbitMqModule))]
    public class test2DomainModule : AbpModule
{

}
