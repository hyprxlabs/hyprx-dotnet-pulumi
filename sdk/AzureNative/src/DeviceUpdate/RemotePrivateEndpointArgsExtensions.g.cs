// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DeviceUpdate.Inputs;

namespace Pulumi.AzureNative.DeviceUpdate;

public static partial class RemotePrivateEndpointArgsExtensions
{
    public static global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs WithId(this global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs WithImmutableResourceId(this global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs @selfRef, global::System.String immutableResourceId)
    {
        @selfRef.ImmutableResourceId = immutableResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs WithImmutableSubscriptionId(this global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs @selfRef, global::System.String immutableSubscriptionId)
    {
        @selfRef.ImmutableSubscriptionId = immutableSubscriptionId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs WithLocation(this global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs WithManualPrivateLinkServiceConnections(this global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DeviceUpdate.Inputs.PrivateLinkServiceConnectionArgs> manualPrivateLinkServiceConnections)
    {
        @selfRef.ManualPrivateLinkServiceConnections = manualPrivateLinkServiceConnections;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs WithManualPrivateLinkServiceConnections(this global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DeviceUpdate.Inputs.PrivateLinkServiceConnectionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DeviceUpdate.Inputs.PrivateLinkServiceConnectionArgs>();
        @configure(@list);
        @selfRef.ManualPrivateLinkServiceConnections = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs WithManualPrivateLinkServiceConnections(this global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DeviceUpdate.Inputs.PrivateLinkServiceConnectionArgs>> @create)
    {
        @selfRef.ManualPrivateLinkServiceConnections = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs WithPrivateLinkServiceConnections(this global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DeviceUpdate.Inputs.PrivateLinkServiceConnectionArgs> privateLinkServiceConnections)
    {
        @selfRef.PrivateLinkServiceConnections = privateLinkServiceConnections;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs WithPrivateLinkServiceConnections(this global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DeviceUpdate.Inputs.PrivateLinkServiceConnectionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DeviceUpdate.Inputs.PrivateLinkServiceConnectionArgs>();
        @configure(@list);
        @selfRef.PrivateLinkServiceConnections = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs WithPrivateLinkServiceConnections(this global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DeviceUpdate.Inputs.PrivateLinkServiceConnectionArgs>> @create)
    {
        @selfRef.PrivateLinkServiceConnections = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs WithPrivateLinkServiceProxies(this global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DeviceUpdate.Inputs.PrivateLinkServiceProxyArgs> privateLinkServiceProxies)
    {
        @selfRef.PrivateLinkServiceProxies = privateLinkServiceProxies;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs WithPrivateLinkServiceProxies(this global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DeviceUpdate.Inputs.PrivateLinkServiceProxyArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DeviceUpdate.Inputs.PrivateLinkServiceProxyArgs>();
        @configure(@list);
        @selfRef.PrivateLinkServiceProxies = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs WithPrivateLinkServiceProxies(this global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DeviceUpdate.Inputs.PrivateLinkServiceProxyArgs>> @create)
    {
        @selfRef.PrivateLinkServiceProxies = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs WithVnetTrafficTag(this global::Pulumi.AzureNative.DeviceUpdate.Inputs.RemotePrivateEndpointArgs @selfRef, global::System.String vnetTrafficTag)
    {
        @selfRef.VnetTrafficTag = vnetTrafficTag;
        return @selfRef;
    }

}
