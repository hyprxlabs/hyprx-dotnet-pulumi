// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs;

namespace Pulumi.AzureNative.ConnectedVMwarevSphere;

public static partial class OsProfileWindowsConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.OsProfileWindowsConfigurationArgs WithAssessmentMode(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.OsProfileWindowsConfigurationArgs @selfRef, global::System.String assessmentMode)
    {
        @selfRef.AssessmentMode = assessmentMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.OsProfileWindowsConfigurationArgs WithPatchMode(this global::Pulumi.AzureNative.ConnectedVMwarevSphere.Inputs.OsProfileWindowsConfigurationArgs @selfRef, global::System.String patchMode)
    {
        @selfRef.PatchMode = patchMode;
        return @selfRef;
    }

}
