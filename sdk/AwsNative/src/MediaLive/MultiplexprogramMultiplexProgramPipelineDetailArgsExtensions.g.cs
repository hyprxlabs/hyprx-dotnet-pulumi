// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.MediaLive.Inputs;

namespace Pulumi.AwsNative.MediaLive;

public static partial class MultiplexprogramMultiplexProgramPipelineDetailArgsExtensions
{
    public static global::Pulumi.AwsNative.MediaLive.Inputs.MultiplexprogramMultiplexProgramPipelineDetailArgs WithActiveChannelPipeline(this global::Pulumi.AwsNative.MediaLive.Inputs.MultiplexprogramMultiplexProgramPipelineDetailArgs @selfRef, global::System.String activeChannelPipeline)
    {
        @selfRef.ActiveChannelPipeline = activeChannelPipeline;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaLive.Inputs.MultiplexprogramMultiplexProgramPipelineDetailArgs WithPipelineId(this global::Pulumi.AwsNative.MediaLive.Inputs.MultiplexprogramMultiplexProgramPipelineDetailArgs @selfRef, global::System.String pipelineId)
    {
        @selfRef.PipelineId = pipelineId;
        return @selfRef;
    }

}
