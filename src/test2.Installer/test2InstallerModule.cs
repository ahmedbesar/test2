using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace test2;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class test2InstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<test2InstallerModule>();
        });
    }
}
