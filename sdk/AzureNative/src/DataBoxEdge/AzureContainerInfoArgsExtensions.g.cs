// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataBoxEdge.Inputs;

namespace Pulumi.AzureNative.DataBoxEdge;

public static partial class AzureContainerInfoArgsExtensions
{
    public static global::Pulumi.AzureNative.DataBoxEdge.Inputs.AzureContainerInfoArgs WithContainerName(this global::Pulumi.AzureNative.DataBoxEdge.Inputs.AzureContainerInfoArgs @selfRef, global::System.String containerName)
    {
        @selfRef.ContainerName = containerName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBoxEdge.Inputs.AzureContainerInfoArgs WithDataFormat(this global::Pulumi.AzureNative.DataBoxEdge.Inputs.AzureContainerInfoArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DataBoxEdge.AzureContainerDataFormat> dataFormat)
    {
        @selfRef.DataFormat = dataFormat;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBoxEdge.Inputs.AzureContainerInfoArgs WithStorageAccountCredentialId(this global::Pulumi.AzureNative.DataBoxEdge.Inputs.AzureContainerInfoArgs @selfRef, global::System.String storageAccountCredentialId)
    {
        @selfRef.StorageAccountCredentialId = storageAccountCredentialId;
        return @selfRef;
    }

}
