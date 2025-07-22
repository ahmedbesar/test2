using Volo.Abp.Reflection;

namespace test2.Permissions;

public class test2Permissions
{
    public const string GroupName = "test2";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(test2Permissions));
    }
}
