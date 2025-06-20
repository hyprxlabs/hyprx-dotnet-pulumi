// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.IoTHub.Inputs;

namespace Pulumi.AzureNative.IoTHub;

public static partial class RoutingServiceBusQueueEndpointPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs WithAuthenticationType(this global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.IoTHub.AuthenticationType> authenticationType)
    {
        @selfRef.AuthenticationType = authenticationType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs WithConnectionString(this global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs @selfRef, global::System.String connectionString)
    {
        @selfRef.ConnectionString = connectionString;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs WithEndpointUri(this global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs @selfRef, global::System.String endpointUri)
    {
        @selfRef.EndpointUri = endpointUri;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs WithEntityPath(this global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs @selfRef, global::System.String entityPath)
    {
        @selfRef.EntityPath = entityPath;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs WithId(this global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs WithIdentity(this global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs @selfRef, global::Pulumi.AzureNative.IoTHub.Inputs.ManagedIdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs WithIdentity(this global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTHub.Inputs.ManagedIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTHub.Inputs.ManagedIdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs WithName(this global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs WithResourceGroup(this global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs @selfRef, global::System.String resourceGroup)
    {
        @selfRef.ResourceGroup = resourceGroup;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs WithSubscriptionId(this global::Pulumi.AzureNative.IoTHub.Inputs.RoutingServiceBusQueueEndpointPropertiesArgs @selfRef, global::System.String subscriptionId)
    {
        @selfRef.SubscriptionId = subscriptionId;
        return @selfRef;
    }

}
