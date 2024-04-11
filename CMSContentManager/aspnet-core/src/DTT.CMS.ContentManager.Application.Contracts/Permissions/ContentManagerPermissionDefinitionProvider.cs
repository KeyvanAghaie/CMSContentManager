using DTT.CMS.ContentManager.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DTT.CMS.ContentManager.Permissions;

public class ContentManagerPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ContentManagerPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ContentManagerPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ContentManagerResource>(name);
    }
}
