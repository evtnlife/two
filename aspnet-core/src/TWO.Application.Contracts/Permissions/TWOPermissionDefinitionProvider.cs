using TWO.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TWO.Permissions;

public class TWOPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TWOPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TWOPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TWOResource>(name);
    }
}
