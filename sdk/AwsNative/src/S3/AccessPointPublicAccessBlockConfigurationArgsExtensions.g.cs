// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.S3.Inputs;

namespace Pulumi.AwsNative.S3;

public static partial class AccessPointPublicAccessBlockConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.S3.Inputs.AccessPointPublicAccessBlockConfigurationArgs WithBlockPublicAcls(this global::Pulumi.AwsNative.S3.Inputs.AccessPointPublicAccessBlockConfigurationArgs @selfRef, bool blockPublicAcls = true)
    {
        @selfRef.BlockPublicAcls = blockPublicAcls;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.S3.Inputs.AccessPointPublicAccessBlockConfigurationArgs WithBlockPublicPolicy(this global::Pulumi.AwsNative.S3.Inputs.AccessPointPublicAccessBlockConfigurationArgs @selfRef, bool blockPublicPolicy = true)
    {
        @selfRef.BlockPublicPolicy = blockPublicPolicy;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.S3.Inputs.AccessPointPublicAccessBlockConfigurationArgs WithIgnorePublicAcls(this global::Pulumi.AwsNative.S3.Inputs.AccessPointPublicAccessBlockConfigurationArgs @selfRef, bool ignorePublicAcls = true)
    {
        @selfRef.IgnorePublicAcls = ignorePublicAcls;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.S3.Inputs.AccessPointPublicAccessBlockConfigurationArgs WithRestrictPublicBuckets(this global::Pulumi.AwsNative.S3.Inputs.AccessPointPublicAccessBlockConfigurationArgs @selfRef, bool restrictPublicBuckets = true)
    {
        @selfRef.RestrictPublicBuckets = restrictPublicBuckets;
        return @selfRef;
    }

}
