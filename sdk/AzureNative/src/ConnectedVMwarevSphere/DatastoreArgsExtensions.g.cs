// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ConnectedVMwarevSphere;

public static partial class DatastoreArgsExtensions
{
    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs WithDatastoreName(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs @selfRef, global::System.String datastoreName)
    {
        @selfRef.DatastoreName = datastoreName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs WithExtendedLocation(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs @selfRef, global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.ExtendedLocationArgs extendedLocation)
    {
        @selfRef.ExtendedLocation = extendedLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs WithExtendedLocation(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.ExtendedLocationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.ExtendedLocationArgs();
        @configure(@item);
        @selfRef.ExtendedLocation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs WithInventoryItemId(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs @selfRef, global::System.String inventoryItemId)
    {
        @selfRef.InventoryItemId = inventoryItemId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs WithKind(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs @selfRef, global::System.String kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs WithLocation(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs WithMoRefId(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs @selfRef, global::System.String moRefId)
    {
        @selfRef.MoRefId = moRefId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs WithResourceGroupName(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs WithTags(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs WithTags(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs WithTags(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs WithVCenterId(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.DatastoreArgs @selfRef, global::System.String vCenterId)
    {
        @selfRef.VCenterId = vCenterId;
        return @selfRef;
    }

}
