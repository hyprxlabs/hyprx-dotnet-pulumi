// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ServiceLinker.Inputs;

namespace Pulumi.AzureNative.ServiceLinker;

public static partial class SecretStoreArgsExtensions
{
    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.SecretStoreArgs WithKeyVaultId(this global::Pulumi.AzureNative.ServiceLinker.Inputs.SecretStoreArgs @selfRef, global::System.String keyVaultId)
    {
        @selfRef.KeyVaultId = keyVaultId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.SecretStoreArgs WithKeyVaultSecretName(this global::Pulumi.AzureNative.ServiceLinker.Inputs.SecretStoreArgs @selfRef, global::System.String keyVaultSecretName)
    {
        @selfRef.KeyVaultSecretName = keyVaultSecretName;
        return @selfRef;
    }

}
