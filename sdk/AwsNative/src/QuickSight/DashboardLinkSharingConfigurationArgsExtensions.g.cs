// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardLinkSharingConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLinkSharingConfigurationArgs WithPermissions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLinkSharingConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardResourcePermissionArgs> permissions)
    {
        @selfRef.Permissions = permissions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLinkSharingConfigurationArgs WithPermissions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLinkSharingConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardResourcePermissionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardResourcePermissionArgs>();
        @configure(@list);
        @selfRef.Permissions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLinkSharingConfigurationArgs WithPermissions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLinkSharingConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardResourcePermissionArgs>> @create)
    {
        @selfRef.Permissions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
