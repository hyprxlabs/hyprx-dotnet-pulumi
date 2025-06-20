// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HybridCompute.Inputs;

namespace Pulumi.AzureNative.HybridCompute;

public static partial class OSProfileLinuxConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.HybridCompute.Inputs.OSProfileLinuxConfigurationArgs WithAssessmentMode(this global::Pulumi.AzureNative.HybridCompute.Inputs.OSProfileLinuxConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.HybridCompute.AssessmentModeTypes> assessmentMode)
    {
        @selfRef.AssessmentMode = assessmentMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridCompute.Inputs.OSProfileLinuxConfigurationArgs WithEnableHotpatching(this global::Pulumi.AzureNative.HybridCompute.Inputs.OSProfileLinuxConfigurationArgs @selfRef, bool enableHotpatching = true)
    {
        @selfRef.EnableHotpatching = enableHotpatching;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridCompute.Inputs.OSProfileLinuxConfigurationArgs WithPatchMode(this global::Pulumi.AzureNative.HybridCompute.Inputs.OSProfileLinuxConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.HybridCompute.PatchModeTypes> patchMode)
    {
        @selfRef.PatchMode = patchMode;
        return @selfRef;
    }

}
