// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataReplication.Inputs;

namespace Pulumi.AzureNative.DataReplication;

public static partial class PrivateEndpointConnectionProxyPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.DataReplication.Inputs.PrivateEndpointConnectionProxyPropertiesArgs WithRemotePrivateEndpoint(this global::Pulumi.AzureNative.DataReplication.Inputs.PrivateEndpointConnectionProxyPropertiesArgs @selfRef, global::Pulumi.AzureNative.DataReplication.Inputs.RemotePrivateEndpointArgs remotePrivateEndpoint)
    {
        @selfRef.RemotePrivateEndpoint = remotePrivateEndpoint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataReplication.Inputs.PrivateEndpointConnectionProxyPropertiesArgs WithRemotePrivateEndpoint(this global::Pulumi.AzureNative.DataReplication.Inputs.PrivateEndpointConnectionProxyPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataReplication.Inputs.RemotePrivateEndpointArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataReplication.Inputs.RemotePrivateEndpointArgs();
        @configure(@item);
        @selfRef.RemotePrivateEndpoint = @item;
        return @selfRef;
    }

}
