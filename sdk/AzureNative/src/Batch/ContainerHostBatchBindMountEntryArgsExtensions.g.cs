// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Batch.Inputs;

namespace Pulumi.AzureNative.Batch;

public static partial class ContainerHostBatchBindMountEntryArgsExtensions
{
    public static global::Pulumi.AzureNative.Batch.Inputs.ContainerHostBatchBindMountEntryArgs WithIsReadOnly(this global::Pulumi.AzureNative.Batch.Inputs.ContainerHostBatchBindMountEntryArgs @selfRef, bool isReadOnly = true)
    {
        @selfRef.IsReadOnly = isReadOnly;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.ContainerHostBatchBindMountEntryArgs WithSource(this global::Pulumi.AzureNative.Batch.Inputs.ContainerHostBatchBindMountEntryArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Batch.ContainerHostDataPath> source)
    {
        @selfRef.Source = source;
        return @selfRef;
    }

}
