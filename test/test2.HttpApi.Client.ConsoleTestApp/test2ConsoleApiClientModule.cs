using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace test2;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(test2HttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class test2ConsoleApiClientModule : AbpModule
{

}
