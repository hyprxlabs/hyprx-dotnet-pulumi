// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.S3.Inputs;

namespace Pulumi.AwsNative.S3;

public static partial class StorageLensSelectionCriteriaArgsExtensions
{
    public static global::Pulumi.AwsNative.S3.Inputs.StorageLensSelectionCriteriaArgs WithDelimiter(this global::Pulumi.AwsNative.S3.Inputs.StorageLensSelectionCriteriaArgs @selfRef, global::System.String delimiter)
    {
        @selfRef.Delimiter = delimiter;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.S3.Inputs.StorageLensSelectionCriteriaArgs WithMaxDepth(this global::Pulumi.AwsNative.S3.Inputs.StorageLensSelectionCriteriaArgs @selfRef, global::System.Int32 maxDepth)
    {
        @selfRef.MaxDepth = maxDepth;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.S3.Inputs.StorageLensSelectionCriteriaArgs WithMinStorageBytesPercentage(this global::Pulumi.AwsNative.S3.Inputs.StorageLensSelectionCriteriaArgs @selfRef, global::System.Double minStorageBytesPercentage)
    {
        @selfRef.MinStorageBytesPercentage = minStorageBytesPercentage;
        return @selfRef;
    }

}
