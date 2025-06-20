// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.SignalRService;

public static partial class SignalRReplicaArgsExtensions
{
    public static global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs WithLocation(this global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs WithRegionEndpointEnabled(this global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs @selfRef, global::System.String regionEndpointEnabled)
    {
        @selfRef.RegionEndpointEnabled = regionEndpointEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs WithReplicaName(this global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs @selfRef, global::System.String replicaName)
    {
        @selfRef.ReplicaName = replicaName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs WithResourceGroupName(this global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs WithResourceName(this global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs @selfRef, global::System.String resourceName)
    {
        @selfRef.ResourceName = resourceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs WithResourceStopped(this global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs @selfRef, global::System.String resourceStopped)
    {
        @selfRef.ResourceStopped = resourceStopped;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs WithSku(this global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs @selfRef, global::Pulumi.AzureNative.SignalRService.Inputs.ResourceSkuArgs sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs WithSku(this global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.SignalRService.Inputs.ResourceSkuArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.SignalRService.Inputs.ResourceSkuArgs();
        @configure(@item);
        @selfRef.Sku = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs WithTags(this global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs WithTags(this global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs WithTags(this global::Pulumi.AzureNative.SignalRService.SignalRReplicaArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
