// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class DataSourceSemanticChunkingConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceSemanticChunkingConfigurationArgs WithBreakpointPercentileThreshold(this global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceSemanticChunkingConfigurationArgs @selfRef, global::System.Int32 breakpointPercentileThreshold)
    {
        @selfRef.BreakpointPercentileThreshold = breakpointPercentileThreshold;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceSemanticChunkingConfigurationArgs WithBufferSize(this global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceSemanticChunkingConfigurationArgs @selfRef, global::System.Int32 bufferSize)
    {
        @selfRef.BufferSize = bufferSize;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceSemanticChunkingConfigurationArgs WithMaxTokens(this global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceSemanticChunkingConfigurationArgs @selfRef, global::System.Int32 maxTokens)
    {
        @selfRef.MaxTokens = maxTokens;
        return @selfRef;
    }

}
