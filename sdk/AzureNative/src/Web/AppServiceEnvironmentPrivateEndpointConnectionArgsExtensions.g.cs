// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Web;

public static partial class AppServiceEnvironmentPrivateEndpointConnectionArgsExtensions
{
    public static global::Pulumi.AzureNative.Web.AppServiceEnvironmentPrivateEndpointConnectionArgs WithIpAddresses(this global::Pulumi.AzureNative.Web.AppServiceEnvironmentPrivateEndpointConnectionArgs @selfRef, global::System.Collections.Generic.List<global::System.String> ipAddresses)
    {
        @selfRef.IpAddresses = ipAddresses;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.AppServiceEnvironmentPrivateEndpointConnectionArgs WithIpAddresses(this global::Pulumi.AzureNative.Web.AppServiceEnvironmentPrivateEndpointConnectionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.IpAddresses = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.AppServiceEnvironmentPrivateEndpointConnectionArgs WithIpAddresses(this global::Pulumi.AzureNative.Web.AppServiceEnvironmentPrivateEndpointConnectionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.IpAddresses = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.AppServiceEnvironmentPrivateEndpointConnectionArgs WithKind(this global::Pulumi.AzureNative.Web.AppServiceEnvironmentPrivateEndpointConnectionArgs @selfRef, global::System.String kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.AppServiceEnvironmentPrivateEndpointConnectionArgs WithName(this global::Pulumi.AzureNative.Web.AppServiceEnvironmentPrivateEndpointConnectionArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.AppServiceEnvironmentPrivateEndpointConnectionArgs WithPrivateEndpointConnectionName(this global::Pulumi.AzureNative.Web.AppServiceEnvironmentPrivateEndpointConnectionArgs @selfRef, global::System.String privateEndpointConnectionName)
    {
        @selfRef.PrivateEndpointConnectionName = privateEndpointConnectionName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.AppServiceEnvironmentPrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.Web.AppServiceEnvironmentPrivateEndpointConnectionArgs @selfRef, global::Pulumi.AzureNative.Web.Inputs.PrivateLinkConnectionStateArgs privateLinkServiceConnectionState)
    {
        @selfRef.PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.AppServiceEnvironmentPrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.Web.AppServiceEnvironmentPrivateEndpointConnectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Web.Inputs.PrivateLinkConnectionStateArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Web.Inputs.PrivateLinkConnectionStateArgs();
        @configure(@item);
        @selfRef.PrivateLinkServiceConnectionState = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.AppServiceEnvironmentPrivateEndpointConnectionArgs WithResourceGroupName(this global::Pulumi.AzureNative.Web.AppServiceEnvironmentPrivateEndpointConnectionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
