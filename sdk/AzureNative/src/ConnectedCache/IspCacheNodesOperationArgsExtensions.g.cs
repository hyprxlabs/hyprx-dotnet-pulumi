// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ConnectedCache;

public static partial class IspCacheNodesOperationArgsExtensions
{
    public static global::Pulumi.AzureNative.ConnectedCache.IspCacheNodesOperationArgs WithCacheNodeResourceName(this global::Pulumi.AzureNative.ConnectedCache.IspCacheNodesOperationArgs @selfRef, global::System.String cacheNodeResourceName)
    {
        @selfRef.CacheNodeResourceName = cacheNodeResourceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedCache.IspCacheNodesOperationArgs WithCustomerResourceName(this global::Pulumi.AzureNative.ConnectedCache.IspCacheNodesOperationArgs @selfRef, global::System.String customerResourceName)
    {
        @selfRef.CustomerResourceName = customerResourceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedCache.IspCacheNodesOperationArgs WithLocation(this global::Pulumi.AzureNative.ConnectedCache.IspCacheNodesOperationArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedCache.IspCacheNodesOperationArgs WithProperties(this global::Pulumi.AzureNative.ConnectedCache.IspCacheNodesOperationArgs @selfRef, global::Pulumi.AzureNative.ConnectedCache.Inputs.CacheNodePropertyArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedCache.IspCacheNodesOperationArgs WithProperties(this global::Pulumi.AzureNative.ConnectedCache.IspCacheNodesOperationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ConnectedCache.Inputs.CacheNodePropertyArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ConnectedCache.Inputs.CacheNodePropertyArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedCache.IspCacheNodesOperationArgs WithResourceGroupName(this global::Pulumi.AzureNative.ConnectedCache.IspCacheNodesOperationArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedCache.IspCacheNodesOperationArgs WithTags(this global::Pulumi.AzureNative.ConnectedCache.IspCacheNodesOperationArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedCache.IspCacheNodesOperationArgs WithTags(this global::Pulumi.AzureNative.ConnectedCache.IspCacheNodesOperationArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedCache.IspCacheNodesOperationArgs WithTags(this global::Pulumi.AzureNative.ConnectedCache.IspCacheNodesOperationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
