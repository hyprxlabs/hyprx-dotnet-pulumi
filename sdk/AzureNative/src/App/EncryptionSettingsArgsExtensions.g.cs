// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.App.Inputs;

namespace Pulumi.AzureNative.App;

public static partial class EncryptionSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.App.Inputs.EncryptionSettingsArgs WithContainerAppAuthEncryptionSecretName(this global::Pulumi.AzureNative.App.Inputs.EncryptionSettingsArgs @selfRef, global::System.String containerAppAuthEncryptionSecretName)
    {
        @selfRef.ContainerAppAuthEncryptionSecretName = containerAppAuthEncryptionSecretName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.EncryptionSettingsArgs WithContainerAppAuthSigningSecretName(this global::Pulumi.AzureNative.App.Inputs.EncryptionSettingsArgs @selfRef, global::System.String containerAppAuthSigningSecretName)
    {
        @selfRef.ContainerAppAuthSigningSecretName = containerAppAuthSigningSecretName;
        return @selfRef;
    }

}
