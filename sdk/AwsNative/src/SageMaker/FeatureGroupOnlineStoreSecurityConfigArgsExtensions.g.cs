// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class FeatureGroupOnlineStoreSecurityConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.FeatureGroupOnlineStoreSecurityConfigArgs WithKmsKeyId(this global::Pulumi.AwsNative.SageMaker.Inputs.FeatureGroupOnlineStoreSecurityConfigArgs @selfRef, global::System.String kmsKeyId)
    {
        @selfRef.KmsKeyId = kmsKeyId;
        return @selfRef;
    }

}
