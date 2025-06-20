// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Compute;

public static partial class RestorePointArgsExtensions
{
    public static global::Pulumi.AzureNative.Compute.RestorePointArgs WithConsistencyMode(this global::Pulumi.AzureNative.Compute.RestorePointArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Compute.ConsistencyModeTypes> consistencyMode)
    {
        @selfRef.ConsistencyMode = consistencyMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.RestorePointArgs WithExcludeDisks(this global::Pulumi.AzureNative.Compute.RestorePointArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.ApiEntityReferenceArgs> excludeDisks)
    {
        @selfRef.ExcludeDisks = excludeDisks;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.RestorePointArgs WithExcludeDisks(this global::Pulumi.AzureNative.Compute.RestorePointArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.ApiEntityReferenceArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.ApiEntityReferenceArgs>();
        @configure(@list);
        @selfRef.ExcludeDisks = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.RestorePointArgs WithExcludeDisks(this global::Pulumi.AzureNative.Compute.RestorePointArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Compute.Inputs.ApiEntityReferenceArgs>> @create)
    {
        @selfRef.ExcludeDisks = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.RestorePointArgs WithResourceGroupName(this global::Pulumi.AzureNative.Compute.RestorePointArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.RestorePointArgs WithRestorePointCollectionName(this global::Pulumi.AzureNative.Compute.RestorePointArgs @selfRef, global::System.String restorePointCollectionName)
    {
        @selfRef.RestorePointCollectionName = restorePointCollectionName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.RestorePointArgs WithRestorePointName(this global::Pulumi.AzureNative.Compute.RestorePointArgs @selfRef, global::System.String restorePointName)
    {
        @selfRef.RestorePointName = restorePointName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.RestorePointArgs WithSourceMetadata(this global::Pulumi.AzureNative.Compute.RestorePointArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.RestorePointSourceMetadataArgs sourceMetadata)
    {
        @selfRef.SourceMetadata = sourceMetadata;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.RestorePointArgs WithSourceMetadata(this global::Pulumi.AzureNative.Compute.RestorePointArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.RestorePointSourceMetadataArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.RestorePointSourceMetadataArgs();
        @configure(@item);
        @selfRef.SourceMetadata = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.RestorePointArgs WithSourceRestorePoint(this global::Pulumi.AzureNative.Compute.RestorePointArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.ApiEntityReferenceArgs sourceRestorePoint)
    {
        @selfRef.SourceRestorePoint = sourceRestorePoint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.RestorePointArgs WithSourceRestorePoint(this global::Pulumi.AzureNative.Compute.RestorePointArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.ApiEntityReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.ApiEntityReferenceArgs();
        @configure(@item);
        @selfRef.SourceRestorePoint = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.RestorePointArgs WithTimeCreated(this global::Pulumi.AzureNative.Compute.RestorePointArgs @selfRef, global::System.String timeCreated)
    {
        @selfRef.TimeCreated = timeCreated;
        return @selfRef;
    }

}
