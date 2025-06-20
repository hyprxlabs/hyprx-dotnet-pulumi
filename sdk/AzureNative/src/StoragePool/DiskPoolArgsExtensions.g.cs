// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.StoragePool;

public static partial class DiskPoolArgsExtensions
{
    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithAdditionalCapabilities(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.Collections.Generic.List<global::System.String> additionalCapabilities)
    {
        @selfRef.AdditionalCapabilities = additionalCapabilities;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithAdditionalCapabilities(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AdditionalCapabilities = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithAdditionalCapabilities(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AdditionalCapabilities = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithAvailabilityZones(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.Collections.Generic.List<global::System.String> availabilityZones)
    {
        @selfRef.AvailabilityZones = availabilityZones;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithAvailabilityZones(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AvailabilityZones = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithAvailabilityZones(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AvailabilityZones = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithDiskPoolName(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.String diskPoolName)
    {
        @selfRef.DiskPoolName = diskPoolName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithDisks(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.StoragePool.Inputs.DiskArgs> disks)
    {
        @selfRef.Disks = disks;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithDisks(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.StoragePool.Inputs.DiskArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.StoragePool.Inputs.DiskArgs>();
        @configure(@list);
        @selfRef.Disks = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithDisks(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.StoragePool.Inputs.DiskArgs>> @create)
    {
        @selfRef.Disks = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithLocation(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithManagedBy(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.String managedBy)
    {
        @selfRef.ManagedBy = managedBy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithManagedByExtended(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.Collections.Generic.List<global::System.String> managedByExtended)
    {
        @selfRef.ManagedByExtended = managedByExtended;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithManagedByExtended(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ManagedByExtended = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithManagedByExtended(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ManagedByExtended = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithResourceGroupName(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithSku(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::Pulumi.AzureNative.StoragePool.Inputs.SkuArgs sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithSku(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.StoragePool.Inputs.SkuArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.StoragePool.Inputs.SkuArgs();
        @configure(@item);
        @selfRef.Sku = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithSubnetId(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.String subnetId)
    {
        @selfRef.SubnetId = subnetId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithTags(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithTags(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StoragePool.DiskPoolArgs WithTags(this global::Pulumi.AzureNative.StoragePool.DiskPoolArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
