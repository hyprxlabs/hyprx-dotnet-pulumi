// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.CodePipeline.Inputs;

namespace Pulumi.AwsNative.CodePipeline;

public static partial class PipelineEncryptionKeyArgsExtensions
{
    public static global::Pulumi.AwsNative.CodePipeline.Inputs.PipelineEncryptionKeyArgs WithId(this global::Pulumi.AwsNative.CodePipeline.Inputs.PipelineEncryptionKeyArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodePipeline.Inputs.PipelineEncryptionKeyArgs WithType(this global::Pulumi.AwsNative.CodePipeline.Inputs.PipelineEncryptionKeyArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
