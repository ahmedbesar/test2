using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace test2.Blazor.WebAssembly;

[DependsOn(
    typeof(test2BlazorModule),
    typeof(test2HttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class test2BlazorWebAssemblyModule : AbpModule
{

}
