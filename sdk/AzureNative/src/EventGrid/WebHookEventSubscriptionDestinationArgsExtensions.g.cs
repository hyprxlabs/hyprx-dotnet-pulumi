// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.EventGrid.Inputs;

namespace Pulumi.AzureNative.EventGrid;

public static partial class WebHookEventSubscriptionDestinationArgsExtensions
{
    public static global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs WithAzureActiveDirectoryApplicationIdOrUri(this global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs @selfRef, global::System.String azureActiveDirectoryApplicationIdOrUri)
    {
        @selfRef.AzureActiveDirectoryApplicationIdOrUri = azureActiveDirectoryApplicationIdOrUri;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs WithAzureActiveDirectoryTenantId(this global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs @selfRef, global::System.String azureActiveDirectoryTenantId)
    {
        @selfRef.AzureActiveDirectoryTenantId = azureActiveDirectoryTenantId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs WithDeliveryAttributeMappings(this global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::Pulumi.AzureNative.EventGrid.Inputs.DynamicDeliveryAttributeMappingArgs, global::Pulumi.AzureNative.EventGrid.Inputs.StaticDeliveryAttributeMappingArgs>> deliveryAttributeMappings)
    {
        @selfRef.DeliveryAttributeMappings = deliveryAttributeMappings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs WithDeliveryAttributeMappings(this global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::Pulumi.AzureNative.EventGrid.Inputs.DynamicDeliveryAttributeMappingArgs, global::Pulumi.AzureNative.EventGrid.Inputs.StaticDeliveryAttributeMappingArgs>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::Pulumi.AzureNative.EventGrid.Inputs.DynamicDeliveryAttributeMappingArgs, global::Pulumi.AzureNative.EventGrid.Inputs.StaticDeliveryAttributeMappingArgs>>();
        @configure(@list);
        @selfRef.DeliveryAttributeMappings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs WithDeliveryAttributeMappings(this global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::Pulumi.AzureNative.EventGrid.Inputs.DynamicDeliveryAttributeMappingArgs, global::Pulumi.AzureNative.EventGrid.Inputs.StaticDeliveryAttributeMappingArgs>>> @create)
    {
        @selfRef.DeliveryAttributeMappings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs WithEndpointType(this global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs @selfRef, global::System.String endpointType)
    {
        @selfRef.EndpointType = endpointType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs WithEndpointUrl(this global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs @selfRef, global::System.String endpointUrl)
    {
        @selfRef.EndpointUrl = endpointUrl;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs WithMaxEventsPerBatch(this global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs @selfRef, global::System.Int32 maxEventsPerBatch)
    {
        @selfRef.MaxEventsPerBatch = maxEventsPerBatch;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs WithMinimumTlsVersionAllowed(this global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.EventGrid.TlsVersion> minimumTlsVersionAllowed)
    {
        @selfRef.MinimumTlsVersionAllowed = minimumTlsVersionAllowed;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs WithPreferredBatchSizeInKilobytes(this global::Pulumi.AzureNative.EventGrid.Inputs.WebHookEventSubscriptionDestinationArgs @selfRef, global::System.Int32 preferredBatchSizeInKilobytes)
    {
        @selfRef.PreferredBatchSizeInKilobytes = preferredBatchSizeInKilobytes;
        return @selfRef;
    }

}
