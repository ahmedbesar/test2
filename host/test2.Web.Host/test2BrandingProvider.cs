using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace test2;

[Dependency(ReplaceServices = true)]
public class test2BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "test2";
}
