// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DeviceRegistry.Inputs;

namespace Pulumi.AzureNative.DeviceRegistry;

public static partial class DiscoveredEventArgsExtensions
{
    public static global::Pulumi.AzureNative.DeviceRegistry.Inputs.DiscoveredEventArgs WithEventConfiguration(this global::Pulumi.AzureNative.DeviceRegistry.Inputs.DiscoveredEventArgs @selfRef, global::System.String eventConfiguration)
    {
        @selfRef.EventConfiguration = eventConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceRegistry.Inputs.DiscoveredEventArgs WithEventNotifier(this global::Pulumi.AzureNative.DeviceRegistry.Inputs.DiscoveredEventArgs @selfRef, global::System.String eventNotifier)
    {
        @selfRef.EventNotifier = eventNotifier;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceRegistry.Inputs.DiscoveredEventArgs WithLastUpdatedOn(this global::Pulumi.AzureNative.DeviceRegistry.Inputs.DiscoveredEventArgs @selfRef, global::System.String lastUpdatedOn)
    {
        @selfRef.LastUpdatedOn = lastUpdatedOn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceRegistry.Inputs.DiscoveredEventArgs WithName(this global::Pulumi.AzureNative.DeviceRegistry.Inputs.DiscoveredEventArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceRegistry.Inputs.DiscoveredEventArgs WithTopic(this global::Pulumi.AzureNative.DeviceRegistry.Inputs.DiscoveredEventArgs @selfRef, global::Pulumi.AzureNative.DeviceRegistry.Inputs.TopicArgs topic)
    {
        @selfRef.Topic = topic;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceRegistry.Inputs.DiscoveredEventArgs WithTopic(this global::Pulumi.AzureNative.DeviceRegistry.Inputs.DiscoveredEventArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DeviceRegistry.Inputs.TopicArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DeviceRegistry.Inputs.TopicArgs();
        @configure(@item);
        @selfRef.Topic = @item;
        return @selfRef;
    }

}
