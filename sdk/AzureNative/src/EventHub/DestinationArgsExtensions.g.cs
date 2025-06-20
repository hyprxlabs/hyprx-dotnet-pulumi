// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.EventHub.Inputs;

namespace Pulumi.AzureNative.EventHub;

public static partial class DestinationArgsExtensions
{
    public static global::Pulumi.AzureNative.EventHub.Inputs.DestinationArgs WithArchiveNameFormat(this global::Pulumi.AzureNative.EventHub.Inputs.DestinationArgs @selfRef, global::System.String archiveNameFormat)
    {
        @selfRef.ArchiveNameFormat = archiveNameFormat;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.Inputs.DestinationArgs WithBlobContainer(this global::Pulumi.AzureNative.EventHub.Inputs.DestinationArgs @selfRef, global::System.String blobContainer)
    {
        @selfRef.BlobContainer = blobContainer;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.Inputs.DestinationArgs WithDataLakeAccountName(this global::Pulumi.AzureNative.EventHub.Inputs.DestinationArgs @selfRef, global::System.String dataLakeAccountName)
    {
        @selfRef.DataLakeAccountName = dataLakeAccountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.Inputs.DestinationArgs WithDataLakeFolderPath(this global::Pulumi.AzureNative.EventHub.Inputs.DestinationArgs @selfRef, global::System.String dataLakeFolderPath)
    {
        @selfRef.DataLakeFolderPath = dataLakeFolderPath;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.Inputs.DestinationArgs WithDataLakeSubscriptionId(this global::Pulumi.AzureNative.EventHub.Inputs.DestinationArgs @selfRef, global::System.String dataLakeSubscriptionId)
    {
        @selfRef.DataLakeSubscriptionId = dataLakeSubscriptionId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.Inputs.DestinationArgs WithIdentity(this global::Pulumi.AzureNative.EventHub.Inputs.DestinationArgs @selfRef, global::Pulumi.AzureNative.EventHub.Inputs.CaptureIdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.Inputs.DestinationArgs WithIdentity(this global::Pulumi.AzureNative.EventHub.Inputs.DestinationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.EventHub.Inputs.CaptureIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.EventHub.Inputs.CaptureIdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.Inputs.DestinationArgs WithName(this global::Pulumi.AzureNative.EventHub.Inputs.DestinationArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.Inputs.DestinationArgs WithStorageAccountResourceId(this global::Pulumi.AzureNative.EventHub.Inputs.DestinationArgs @selfRef, global::System.String storageAccountResourceId)
    {
        @selfRef.StorageAccountResourceId = storageAccountResourceId;
        return @selfRef;
    }

}
