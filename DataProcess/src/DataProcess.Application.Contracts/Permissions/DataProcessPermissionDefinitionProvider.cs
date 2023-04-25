using DataProcess.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DataProcess.Permissions;

public class DataProcessPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DataProcessPermissions.GroupName, L("Permission:DataProcess"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DataProcessResource>(name);
    }
}
