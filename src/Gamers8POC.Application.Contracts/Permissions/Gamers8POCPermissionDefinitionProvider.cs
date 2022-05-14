using Gamers8POC.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Gamers8POC.Permissions;

public class Gamers8POCPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Gamers8POCPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Gamers8POCPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Gamers8POCResource>(name);
    }
}
