// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AVS.Inputs;

namespace Pulumi.AzureNative.AVS;

public static partial class EncryptionKeyVaultPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AVS.Inputs.EncryptionKeyVaultPropertiesArgs WithKeyName(this global::Pulumi.AzureNative.AVS.Inputs.EncryptionKeyVaultPropertiesArgs @selfRef, global::System.String keyName)
    {
        @selfRef.KeyName = keyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AVS.Inputs.EncryptionKeyVaultPropertiesArgs WithKeyVaultUrl(this global::Pulumi.AzureNative.AVS.Inputs.EncryptionKeyVaultPropertiesArgs @selfRef, global::System.String keyVaultUrl)
    {
        @selfRef.KeyVaultUrl = keyVaultUrl;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AVS.Inputs.EncryptionKeyVaultPropertiesArgs WithKeyVersion(this global::Pulumi.AzureNative.AVS.Inputs.EncryptionKeyVaultPropertiesArgs @selfRef, global::System.String keyVersion)
    {
        @selfRef.KeyVersion = keyVersion;
        return @selfRef;
    }

}
