// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class ComputeInstanceSshSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeInstanceSshSettingsArgs WithAdminPublicKey(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeInstanceSshSettingsArgs @selfRef, global::System.String adminPublicKey)
    {
        @selfRef.AdminPublicKey = adminPublicKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeInstanceSshSettingsArgs WithSshPublicAccess(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeInstanceSshSettingsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.SshPublicAccess> sshPublicAccess)
    {
        @selfRef.SshPublicAccess = sshPublicAccess;
        return @selfRef;
    }

}
