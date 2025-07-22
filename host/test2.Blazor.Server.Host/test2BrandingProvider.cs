using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace test2.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class test2BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "test2";
}
