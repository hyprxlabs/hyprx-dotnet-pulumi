// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ElasticSan;

public static partial class ElasticSanArgsExtensions
{
    public static global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs WithAvailabilityZones(this global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs @selfRef, global::System.Collections.Generic.List<global::System.String> availabilityZones)
    {
        @selfRef.AvailabilityZones = availabilityZones;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs WithAvailabilityZones(this global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AvailabilityZones = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs WithAvailabilityZones(this global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AvailabilityZones = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs WithBaseSizeTiB(this global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs @selfRef, global::System.Double baseSizeTiB)
    {
        @selfRef.BaseSizeTiB = baseSizeTiB;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs WithElasticSanName(this global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs @selfRef, global::System.String elasticSanName)
    {
        @selfRef.ElasticSanName = elasticSanName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs WithExtendedCapacitySizeTiB(this global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs @selfRef, global::System.Double extendedCapacitySizeTiB)
    {
        @selfRef.ExtendedCapacitySizeTiB = extendedCapacitySizeTiB;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs WithLocation(this global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs WithPublicNetworkAccess(this global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ElasticSan.PublicNetworkAccess> publicNetworkAccess)
    {
        @selfRef.PublicNetworkAccess = publicNetworkAccess;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs WithResourceGroupName(this global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs WithSku(this global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs @selfRef, global::Pulumi.AzureNative.ElasticSan.Inputs.SkuArgs sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs WithSku(this global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ElasticSan.Inputs.SkuArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ElasticSan.Inputs.SkuArgs();
        @configure(@item);
        @selfRef.Sku = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs WithTags(this global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs WithTags(this global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs WithTags(this global::Pulumi.AzureNative.ElasticSan.ElasticSanArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
