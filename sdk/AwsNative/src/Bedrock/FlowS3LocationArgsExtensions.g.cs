// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class FlowS3LocationArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.FlowS3LocationArgs WithBucket(this global::Pulumi.AwsNative.Bedrock.Inputs.FlowS3LocationArgs @selfRef, global::System.String bucket)
    {
        @selfRef.Bucket = bucket;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.FlowS3LocationArgs WithKey(this global::Pulumi.AwsNative.Bedrock.Inputs.FlowS3LocationArgs @selfRef, global::System.String key)
    {
        @selfRef.Key = key;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.FlowS3LocationArgs WithVersion(this global::Pulumi.AwsNative.Bedrock.Inputs.FlowS3LocationArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
