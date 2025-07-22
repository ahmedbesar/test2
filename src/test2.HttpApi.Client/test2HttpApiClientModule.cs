using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace test2;

[DependsOn(
    typeof(test2ApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class test2HttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(test2ApplicationContractsModule).Assembly,
            test2RemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<test2HttpApiClientModule>();
        });

    }
}
