// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ManagedNetworkFabric;

public static partial class NetworkTapArgsExtensions
{
    public static global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs WithAnnotation(this global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs @selfRef, global::System.String annotation)
    {
        @selfRef.Annotation = annotation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs WithDestinations(this global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapPropertiesDestinationsArgs> destinations)
    {
        @selfRef.Destinations = destinations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs WithDestinations(this global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapPropertiesDestinationsArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapPropertiesDestinationsArgs>();
        @configure(@list);
        @selfRef.Destinations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs WithDestinations(this global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapPropertiesDestinationsArgs>> @create)
    {
        @selfRef.Destinations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs WithLocation(this global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs WithNetworkPacketBrokerId(this global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs @selfRef, global::System.String networkPacketBrokerId)
    {
        @selfRef.NetworkPacketBrokerId = networkPacketBrokerId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs WithNetworkTapName(this global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs @selfRef, global::System.String networkTapName)
    {
        @selfRef.NetworkTapName = networkTapName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs WithPollingType(this global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ManagedNetworkFabric.PollingType> pollingType)
    {
        @selfRef.PollingType = pollingType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs WithResourceGroupName(this global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs WithTags(this global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs WithTags(this global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs WithTags(this global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkTapArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
