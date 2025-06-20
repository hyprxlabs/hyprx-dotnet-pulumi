// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ManagedNetworkFabric.Inputs;

namespace Pulumi.AzureNative.ManagedNetworkFabric;

public static partial class AggregateRouteConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteConfigurationArgs WithIpv4Routes(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteArgs> ipv4Routes)
    {
        @selfRef.Ipv4Routes = ipv4Routes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteConfigurationArgs WithIpv4Routes(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteArgs>();
        @configure(@list);
        @selfRef.Ipv4Routes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteConfigurationArgs WithIpv4Routes(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteArgs>> @create)
    {
        @selfRef.Ipv4Routes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteConfigurationArgs WithIpv6Routes(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteArgs> ipv6Routes)
    {
        @selfRef.Ipv6Routes = ipv6Routes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteConfigurationArgs WithIpv6Routes(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteArgs>();
        @configure(@list);
        @selfRef.Ipv6Routes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteConfigurationArgs WithIpv6Routes(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.AggregateRouteArgs>> @create)
    {
        @selfRef.Ipv6Routes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
