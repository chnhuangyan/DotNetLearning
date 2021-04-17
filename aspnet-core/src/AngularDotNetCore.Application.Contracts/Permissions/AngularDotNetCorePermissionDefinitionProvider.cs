using AngularDotNetCore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AngularDotNetCore.Permissions
{
    public class AngularDotNetCorePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AngularDotNetCorePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AngularDotNetCorePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AngularDotNetCoreResource>(name);
        }
    }
}
