// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class InferenceExperimentShadowModelVariantConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.InferenceExperimentShadowModelVariantConfigArgs WithSamplingPercentage(this global::Pulumi.AwsNative.SageMaker.Inputs.InferenceExperimentShadowModelVariantConfigArgs @selfRef, global::System.Int32 samplingPercentage)
    {
        @selfRef.SamplingPercentage = samplingPercentage;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.InferenceExperimentShadowModelVariantConfigArgs WithShadowModelVariantName(this global::Pulumi.AwsNative.SageMaker.Inputs.InferenceExperimentShadowModelVariantConfigArgs @selfRef, global::System.String shadowModelVariantName)
    {
        @selfRef.ShadowModelVariantName = shadowModelVariantName;
        return @selfRef;
    }

}
