// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoT.Inputs;

namespace Pulumi.AwsNative.IoT;

public static partial class SecurityProfileMachineLearningDetectionConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMachineLearningDetectionConfigArgs WithConfidenceLevel(this global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMachineLearningDetectionConfigArgs @selfRef, global::Pulumi.AwsNative.IoT.SecurityProfileMachineLearningDetectionConfigConfidenceLevel confidenceLevel)
    {
        @selfRef.ConfidenceLevel = confidenceLevel;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMachineLearningDetectionConfigArgs WithConfidenceLevel(this global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMachineLearningDetectionConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoT.SecurityProfileMachineLearningDetectionConfigConfidenceLevel> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.IoT.SecurityProfileMachineLearningDetectionConfigConfidenceLevel>();
        @configure(@item);
        @selfRef.ConfidenceLevel = @item;
        return @selfRef;
    }

}
