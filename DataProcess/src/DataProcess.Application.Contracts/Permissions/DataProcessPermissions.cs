using Volo.Abp.Reflection;

namespace DataProcess.Permissions;

public class DataProcessPermissions
{
    public const string GroupName = "DataProcess";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(DataProcessPermissions));
    }
}
