// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Databricks.Inputs;

namespace Pulumi.AzureNative.Databricks;

public static partial class ManagedDiskEncryptionKeyVaultPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.Databricks.Inputs.ManagedDiskEncryptionKeyVaultPropertiesArgs WithKeyName(this global::Pulumi.AzureNative.Databricks.Inputs.ManagedDiskEncryptionKeyVaultPropertiesArgs @selfRef, global::System.String keyName)
    {
        @selfRef.KeyName = keyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Databricks.Inputs.ManagedDiskEncryptionKeyVaultPropertiesArgs WithKeyVaultUri(this global::Pulumi.AzureNative.Databricks.Inputs.ManagedDiskEncryptionKeyVaultPropertiesArgs @selfRef, global::System.String keyVaultUri)
    {
        @selfRef.KeyVaultUri = keyVaultUri;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Databricks.Inputs.ManagedDiskEncryptionKeyVaultPropertiesArgs WithKeyVersion(this global::Pulumi.AzureNative.Databricks.Inputs.ManagedDiskEncryptionKeyVaultPropertiesArgs @selfRef, global::System.String keyVersion)
    {
        @selfRef.KeyVersion = keyVersion;
        return @selfRef;
    }

}
