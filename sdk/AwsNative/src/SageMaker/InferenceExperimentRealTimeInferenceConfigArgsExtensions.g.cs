// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class InferenceExperimentRealTimeInferenceConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.InferenceExperimentRealTimeInferenceConfigArgs WithInstanceCount(this global::Pulumi.AwsNative.SageMaker.Inputs.InferenceExperimentRealTimeInferenceConfigArgs @selfRef, global::System.Int32 instanceCount)
    {
        @selfRef.InstanceCount = instanceCount;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.InferenceExperimentRealTimeInferenceConfigArgs WithInstanceType(this global::Pulumi.AwsNative.SageMaker.Inputs.InferenceExperimentRealTimeInferenceConfigArgs @selfRef, global::System.String instanceType)
    {
        @selfRef.InstanceType = instanceType;
        return @selfRef;
    }

}
