// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Confluent.Inputs;

namespace Pulumi.AzureNative.Confluent;

public static partial class AzureBlobStorageSinkConnectorServiceInfoArgsExtensions
{
    public static global::Pulumi.AzureNative.Confluent.Inputs.AzureBlobStorageSinkConnectorServiceInfoArgs WithConnectorServiceType(this global::Pulumi.AzureNative.Confluent.Inputs.AzureBlobStorageSinkConnectorServiceInfoArgs @selfRef, global::System.String connectorServiceType)
    {
        @selfRef.ConnectorServiceType = connectorServiceType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.AzureBlobStorageSinkConnectorServiceInfoArgs WithStorageAccountKey(this global::Pulumi.AzureNative.Confluent.Inputs.AzureBlobStorageSinkConnectorServiceInfoArgs @selfRef, global::System.String storageAccountKey)
    {
        @selfRef.StorageAccountKey = storageAccountKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.AzureBlobStorageSinkConnectorServiceInfoArgs WithStorageAccountName(this global::Pulumi.AzureNative.Confluent.Inputs.AzureBlobStorageSinkConnectorServiceInfoArgs @selfRef, global::System.String storageAccountName)
    {
        @selfRef.StorageAccountName = storageAccountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.AzureBlobStorageSinkConnectorServiceInfoArgs WithStorageContainerName(this global::Pulumi.AzureNative.Confluent.Inputs.AzureBlobStorageSinkConnectorServiceInfoArgs @selfRef, global::System.String storageContainerName)
    {
        @selfRef.StorageContainerName = storageContainerName;
        return @selfRef;
    }

}
