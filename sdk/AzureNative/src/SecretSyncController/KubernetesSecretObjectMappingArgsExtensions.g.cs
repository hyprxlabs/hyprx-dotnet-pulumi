// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.SecretSyncController.Inputs;

namespace Pulumi.AzureNative.SecretSyncController;

public static partial class KubernetesSecretObjectMappingArgsExtensions
{
    public static global::Pulumi.AzureNative.SecretSyncController.Inputs.KubernetesSecretObjectMappingArgs WithSourcePath(this global::Pulumi.AzureNative.SecretSyncController.Inputs.KubernetesSecretObjectMappingArgs @selfRef, global::System.String sourcePath)
    {
        @selfRef.SourcePath = sourcePath;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecretSyncController.Inputs.KubernetesSecretObjectMappingArgs WithTargetKey(this global::Pulumi.AzureNative.SecretSyncController.Inputs.KubernetesSecretObjectMappingArgs @selfRef, global::System.String targetKey)
    {
        @selfRef.TargetKey = targetKey;
        return @selfRef;
    }

}
