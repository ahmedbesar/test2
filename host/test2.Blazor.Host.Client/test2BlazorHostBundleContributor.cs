using Volo.Abp.Bundling;

namespace test2.Blazor.Host.Client;

public class test2BlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
