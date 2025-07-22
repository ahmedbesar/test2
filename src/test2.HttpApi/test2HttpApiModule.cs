using Localization.Resources.AbpUi;
using test2.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace test2;

[DependsOn(
    typeof(test2ApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class test2HttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(test2HttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<test2Resource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
