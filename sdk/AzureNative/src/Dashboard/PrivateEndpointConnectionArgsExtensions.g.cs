// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Dashboard;

public static partial class PrivateEndpointConnectionArgsExtensions
{
    public static global::Pulumi.AzureNative.Dashboard.PrivateEndpointConnectionArgs WithGroupIds(this global::Pulumi.AzureNative.Dashboard.PrivateEndpointConnectionArgs @selfRef, global::System.Collections.Generic.List<global::System.String> groupIds)
    {
        @selfRef.GroupIds = groupIds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Dashboard.PrivateEndpointConnectionArgs WithGroupIds(this global::Pulumi.AzureNative.Dashboard.PrivateEndpointConnectionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.GroupIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Dashboard.PrivateEndpointConnectionArgs WithGroupIds(this global::Pulumi.AzureNative.Dashboard.PrivateEndpointConnectionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.GroupIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Dashboard.PrivateEndpointConnectionArgs WithPrivateEndpointConnectionName(this global::Pulumi.AzureNative.Dashboard.PrivateEndpointConnectionArgs @selfRef, global::System.String privateEndpointConnectionName)
    {
        @selfRef.PrivateEndpointConnectionName = privateEndpointConnectionName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Dashboard.PrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.Dashboard.PrivateEndpointConnectionArgs @selfRef, global::Pulumi.AzureNative.Dashboard.Inputs.PrivateLinkServiceConnectionStateArgs privateLinkServiceConnectionState)
    {
        @selfRef.PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Dashboard.PrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.Dashboard.PrivateEndpointConnectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Dashboard.Inputs.PrivateLinkServiceConnectionStateArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Dashboard.Inputs.PrivateLinkServiceConnectionStateArgs();
        @configure(@item);
        @selfRef.PrivateLinkServiceConnectionState = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Dashboard.PrivateEndpointConnectionArgs WithResourceGroupName(this global::Pulumi.AzureNative.Dashboard.PrivateEndpointConnectionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Dashboard.PrivateEndpointConnectionArgs WithWorkspaceName(this global::Pulumi.AzureNative.Dashboard.PrivateEndpointConnectionArgs @selfRef, global::System.String workspaceName)
    {
        @selfRef.WorkspaceName = workspaceName;
        return @selfRef;
    }

}
