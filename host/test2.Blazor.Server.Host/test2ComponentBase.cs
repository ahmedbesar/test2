using test2.Localization;
using Volo.Abp.AspNetCore.Components;

namespace test2.Blazor.Server.Host;

public abstract class test2ComponentBase : AbpComponentBase
{
    protected test2ComponentBase()
    {
        LocalizationResource = typeof(test2Resource);
    }
}
