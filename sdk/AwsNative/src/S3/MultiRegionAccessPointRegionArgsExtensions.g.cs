// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.S3.Inputs;

namespace Pulumi.AwsNative.S3;

public static partial class MultiRegionAccessPointRegionArgsExtensions
{
    public static global::Pulumi.AwsNative.S3.Inputs.MultiRegionAccessPointRegionArgs WithBucket(this global::Pulumi.AwsNative.S3.Inputs.MultiRegionAccessPointRegionArgs @selfRef, global::System.String bucket)
    {
        @selfRef.Bucket = bucket;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.S3.Inputs.MultiRegionAccessPointRegionArgs WithBucketAccountId(this global::Pulumi.AwsNative.S3.Inputs.MultiRegionAccessPointRegionArgs @selfRef, global::System.String bucketAccountId)
    {
        @selfRef.BucketAccountId = bucketAccountId;
        return @selfRef;
    }

}
