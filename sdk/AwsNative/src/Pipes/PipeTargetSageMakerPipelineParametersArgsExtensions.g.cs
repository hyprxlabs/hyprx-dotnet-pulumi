// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Pipes.Inputs;

namespace Pulumi.AwsNative.Pipes;

public static partial class PipeTargetSageMakerPipelineParametersArgsExtensions
{
    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeTargetSageMakerPipelineParametersArgs WithPipelineParameterList(this global::Pulumi.AwsNative.Pipes.Inputs.PipeTargetSageMakerPipelineParametersArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Pipes.Inputs.PipeSageMakerPipelineParameterArgs> pipelineParameterList)
    {
        @selfRef.PipelineParameterList = pipelineParameterList;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeTargetSageMakerPipelineParametersArgs WithPipelineParameterList(this global::Pulumi.AwsNative.Pipes.Inputs.PipeTargetSageMakerPipelineParametersArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Pipes.Inputs.PipeSageMakerPipelineParameterArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Pipes.Inputs.PipeSageMakerPipelineParameterArgs>();
        @configure(@list);
        @selfRef.PipelineParameterList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeTargetSageMakerPipelineParametersArgs WithPipelineParameterList(this global::Pulumi.AwsNative.Pipes.Inputs.PipeTargetSageMakerPipelineParametersArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Pipes.Inputs.PipeSageMakerPipelineParameterArgs>> @create)
    {
        @selfRef.PipelineParameterList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
