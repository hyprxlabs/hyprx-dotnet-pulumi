// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.S3.Inputs;

namespace Pulumi.AwsNative.S3;

public static partial class StorageLensPrefixLevelStorageMetricsArgsExtensions
{
    public static global::Pulumi.AwsNative.S3.Inputs.StorageLensPrefixLevelStorageMetricsArgs WithIsEnabled(this global::Pulumi.AwsNative.S3.Inputs.StorageLensPrefixLevelStorageMetricsArgs @selfRef, bool isEnabled = true)
    {
        @selfRef.IsEnabled = isEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.S3.Inputs.StorageLensPrefixLevelStorageMetricsArgs WithSelectionCriteria(this global::Pulumi.AwsNative.S3.Inputs.StorageLensPrefixLevelStorageMetricsArgs @selfRef, global::Pulumi.AwsNative.S3.Inputs.StorageLensSelectionCriteriaArgs selectionCriteria)
    {
        @selfRef.SelectionCriteria = selectionCriteria;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.S3.Inputs.StorageLensPrefixLevelStorageMetricsArgs WithSelectionCriteria(this global::Pulumi.AwsNative.S3.Inputs.StorageLensPrefixLevelStorageMetricsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.S3.Inputs.StorageLensSelectionCriteriaArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.S3.Inputs.StorageLensSelectionCriteriaArgs();
        @configure(@item);
        @selfRef.SelectionCriteria = @item;
        return @selfRef;
    }

}
