// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.StreamAnalytics;

public static partial class PrivateEndpointArgsExtensions
{
    public static global::Pulumi.AzureNative.StreamAnalytics.PrivateEndpointArgs WithClusterName(this global::Pulumi.AzureNative.StreamAnalytics.PrivateEndpointArgs @selfRef, global::System.String clusterName)
    {
        @selfRef.ClusterName = clusterName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StreamAnalytics.PrivateEndpointArgs WithManualPrivateLinkServiceConnections(this global::Pulumi.AzureNative.StreamAnalytics.PrivateEndpointArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.StreamAnalytics.Inputs.PrivateLinkServiceConnectionArgs> manualPrivateLinkServiceConnections)
    {
        @selfRef.ManualPrivateLinkServiceConnections = manualPrivateLinkServiceConnections;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StreamAnalytics.PrivateEndpointArgs WithManualPrivateLinkServiceConnections(this global::Pulumi.AzureNative.StreamAnalytics.PrivateEndpointArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.StreamAnalytics.Inputs.PrivateLinkServiceConnectionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.StreamAnalytics.Inputs.PrivateLinkServiceConnectionArgs>();
        @configure(@list);
        @selfRef.ManualPrivateLinkServiceConnections = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StreamAnalytics.PrivateEndpointArgs WithManualPrivateLinkServiceConnections(this global::Pulumi.AzureNative.StreamAnalytics.PrivateEndpointArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.StreamAnalytics.Inputs.PrivateLinkServiceConnectionArgs>> @create)
    {
        @selfRef.ManualPrivateLinkServiceConnections = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StreamAnalytics.PrivateEndpointArgs WithPrivateEndpointName(this global::Pulumi.AzureNative.StreamAnalytics.PrivateEndpointArgs @selfRef, global::System.String privateEndpointName)
    {
        @selfRef.PrivateEndpointName = privateEndpointName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StreamAnalytics.PrivateEndpointArgs WithResourceGroupName(this global::Pulumi.AzureNative.StreamAnalytics.PrivateEndpointArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
