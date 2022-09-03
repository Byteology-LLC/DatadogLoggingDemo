using DatadogLoggingDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace DatadogLoggingDemo.Permissions;

public class DatadogLoggingDemoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(DatadogLoggingDemoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(DatadogLoggingDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<DatadogLoggingDemoResource>(name);
    }
}
