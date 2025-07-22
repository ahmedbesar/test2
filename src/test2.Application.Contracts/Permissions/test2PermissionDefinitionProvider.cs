using test2.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace test2.Permissions;

public class test2PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(test2Permissions.GroupName, L("Permission:test2"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<test2Resource>(name);
    }
}
