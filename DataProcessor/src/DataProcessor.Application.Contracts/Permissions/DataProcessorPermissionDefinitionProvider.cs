using DataProcessor.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DataProcessor.Permissions;

public class DataProcessorPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DataProcessorPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(DataProcessorPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DataProcessorResource>(name);
    }
}
