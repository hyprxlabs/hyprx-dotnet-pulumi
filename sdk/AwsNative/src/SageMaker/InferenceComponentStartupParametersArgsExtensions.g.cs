// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class InferenceComponentStartupParametersArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentStartupParametersArgs WithContainerStartupHealthCheckTimeoutInSeconds(this global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentStartupParametersArgs @selfRef, global::System.Int32 containerStartupHealthCheckTimeoutInSeconds)
    {
        @selfRef.ContainerStartupHealthCheckTimeoutInSeconds = containerStartupHealthCheckTimeoutInSeconds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentStartupParametersArgs WithModelDataDownloadTimeoutInSeconds(this global::Pulumi.AwsNative.SageMaker.Inputs.InferenceComponentStartupParametersArgs @selfRef, global::System.Int32 modelDataDownloadTimeoutInSeconds)
    {
        @selfRef.ModelDataDownloadTimeoutInSeconds = modelDataDownloadTimeoutInSeconds;
        return @selfRef;
    }

}
