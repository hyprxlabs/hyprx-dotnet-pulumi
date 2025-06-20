// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ConnectedVMwarevSphere;

public static partial class ResourcePoolArgsExtensions
{
    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs WithExtendedLocation(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs @selfRef, global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.ExtendedLocationArgs extendedLocation)
    {
        @selfRef.ExtendedLocation = extendedLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs WithExtendedLocation(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.ExtendedLocationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.ExtendedLocationArgs();
        @configure(@item);
        @selfRef.ExtendedLocation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs WithInventoryItemId(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs @selfRef, global::System.String inventoryItemId)
    {
        @selfRef.InventoryItemId = inventoryItemId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs WithKind(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs @selfRef, global::System.String kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs WithLocation(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs WithMoRefId(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs @selfRef, global::System.String moRefId)
    {
        @selfRef.MoRefId = moRefId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs WithResourceGroupName(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs WithResourcePoolName(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs @selfRef, global::System.String resourcePoolName)
    {
        @selfRef.ResourcePoolName = resourcePoolName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs WithTags(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs WithTags(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs WithTags(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs WithVCenterId(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.ResourcePoolArgs @selfRef, global::System.String vCenterId)
    {
        @selfRef.VCenterId = vCenterId;
        return @selfRef;
    }

}
