// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ServiceLinker.Inputs;

namespace Pulumi.AzureNative.ServiceLinker;

public static partial class KeyVaultSecretReferenceSecretInfoArgsExtensions
{
    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.KeyVaultSecretReferenceSecretInfoArgs WithName(this global::Pulumi.AzureNative.ServiceLinker.Inputs.KeyVaultSecretReferenceSecretInfoArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.KeyVaultSecretReferenceSecretInfoArgs WithSecretType(this global::Pulumi.AzureNative.ServiceLinker.Inputs.KeyVaultSecretReferenceSecretInfoArgs @selfRef, global::System.String secretType)
    {
        @selfRef.SecretType = secretType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.KeyVaultSecretReferenceSecretInfoArgs WithVersion(this global::Pulumi.AzureNative.ServiceLinker.Inputs.KeyVaultSecretReferenceSecretInfoArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
