// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.EventGrid.Inputs;

namespace Pulumi.AzureNative.EventGrid;

public static partial class ServiceBusQueueEventSubscriptionDestinationArgsExtensions
{
    public static global::Pulumi.AzureNative.EventGrid.Inputs.ServiceBusQueueEventSubscriptionDestinationArgs WithDeliveryAttributeMappings(this global::Pulumi.AzureNative.EventGrid.Inputs.ServiceBusQueueEventSubscriptionDestinationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::Pulumi.AzureNative.EventGrid.Inputs.DynamicDeliveryAttributeMappingArgs, global::Pulumi.AzureNative.EventGrid.Inputs.StaticDeliveryAttributeMappingArgs>> deliveryAttributeMappings)
    {
        @selfRef.DeliveryAttributeMappings = deliveryAttributeMappings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.ServiceBusQueueEventSubscriptionDestinationArgs WithDeliveryAttributeMappings(this global::Pulumi.AzureNative.EventGrid.Inputs.ServiceBusQueueEventSubscriptionDestinationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::Pulumi.AzureNative.EventGrid.Inputs.DynamicDeliveryAttributeMappingArgs, global::Pulumi.AzureNative.EventGrid.Inputs.StaticDeliveryAttributeMappingArgs>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::Pulumi.AzureNative.EventGrid.Inputs.DynamicDeliveryAttributeMappingArgs, global::Pulumi.AzureNative.EventGrid.Inputs.StaticDeliveryAttributeMappingArgs>>();
        @configure(@list);
        @selfRef.DeliveryAttributeMappings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.ServiceBusQueueEventSubscriptionDestinationArgs WithDeliveryAttributeMappings(this global::Pulumi.AzureNative.EventGrid.Inputs.ServiceBusQueueEventSubscriptionDestinationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::Pulumi.AzureNative.EventGrid.Inputs.DynamicDeliveryAttributeMappingArgs, global::Pulumi.AzureNative.EventGrid.Inputs.StaticDeliveryAttributeMappingArgs>>> @create)
    {
        @selfRef.DeliveryAttributeMappings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.ServiceBusQueueEventSubscriptionDestinationArgs WithEndpointType(this global::Pulumi.AzureNative.EventGrid.Inputs.ServiceBusQueueEventSubscriptionDestinationArgs @selfRef, global::System.String endpointType)
    {
        @selfRef.EndpointType = endpointType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.ServiceBusQueueEventSubscriptionDestinationArgs WithResourceId(this global::Pulumi.AzureNative.EventGrid.Inputs.ServiceBusQueueEventSubscriptionDestinationArgs @selfRef, global::System.String resourceId)
    {
        @selfRef.ResourceId = resourceId;
        return @selfRef;
    }

}
