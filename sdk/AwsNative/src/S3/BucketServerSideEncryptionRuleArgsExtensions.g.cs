// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.S3.Inputs;

namespace Pulumi.AwsNative.S3;

public static partial class BucketServerSideEncryptionRuleArgsExtensions
{
    public static global::Pulumi.AwsNative.S3.Inputs.BucketServerSideEncryptionRuleArgs WithBucketKeyEnabled(this global::Pulumi.AwsNative.S3.Inputs.BucketServerSideEncryptionRuleArgs @selfRef, bool bucketKeyEnabled = true)
    {
        @selfRef.BucketKeyEnabled = bucketKeyEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.S3.Inputs.BucketServerSideEncryptionRuleArgs WithServerSideEncryptionByDefault(this global::Pulumi.AwsNative.S3.Inputs.BucketServerSideEncryptionRuleArgs @selfRef, global::Pulumi.AwsNative.S3.Inputs.BucketServerSideEncryptionByDefaultArgs serverSideEncryptionByDefault)
    {
        @selfRef.ServerSideEncryptionByDefault = serverSideEncryptionByDefault;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.S3.Inputs.BucketServerSideEncryptionRuleArgs WithServerSideEncryptionByDefault(this global::Pulumi.AwsNative.S3.Inputs.BucketServerSideEncryptionRuleArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.S3.Inputs.BucketServerSideEncryptionByDefaultArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.S3.Inputs.BucketServerSideEncryptionByDefaultArgs();
        @configure(@item);
        @selfRef.ServerSideEncryptionByDefault = @item;
        return @selfRef;
    }

}
