// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Chaos.Inputs;

namespace Pulumi.AzureNative.Chaos;

public static partial class CustomerDataStoragePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.Chaos.Inputs.CustomerDataStoragePropertiesArgs WithBlobContainerName(this global::Pulumi.AzureNative.Chaos.Inputs.CustomerDataStoragePropertiesArgs @selfRef, global::System.String blobContainerName)
    {
        @selfRef.BlobContainerName = blobContainerName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Chaos.Inputs.CustomerDataStoragePropertiesArgs WithStorageAccountResourceId(this global::Pulumi.AzureNative.Chaos.Inputs.CustomerDataStoragePropertiesArgs @selfRef, global::System.String storageAccountResourceId)
    {
        @selfRef.StorageAccountResourceId = storageAccountResourceId;
        return @selfRef;
    }

}
