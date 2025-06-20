// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HDInsight.Inputs;

namespace Pulumi.AzureNative.HDInsight;

public static partial class DiskEncryptionPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.HDInsight.Inputs.DiskEncryptionPropertiesArgs WithEncryptionAlgorithm(this global::Pulumi.AzureNative.HDInsight.Inputs.DiskEncryptionPropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.HDInsight.JsonWebKeyEncryptionAlgorithm> encryptionAlgorithm)
    {
        @selfRef.EncryptionAlgorithm = encryptionAlgorithm;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.Inputs.DiskEncryptionPropertiesArgs WithEncryptionAtHost(this global::Pulumi.AzureNative.HDInsight.Inputs.DiskEncryptionPropertiesArgs @selfRef, bool encryptionAtHost = true)
    {
        @selfRef.EncryptionAtHost = encryptionAtHost;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.Inputs.DiskEncryptionPropertiesArgs WithKeyName(this global::Pulumi.AzureNative.HDInsight.Inputs.DiskEncryptionPropertiesArgs @selfRef, global::System.String keyName)
    {
        @selfRef.KeyName = keyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.Inputs.DiskEncryptionPropertiesArgs WithKeyVersion(this global::Pulumi.AzureNative.HDInsight.Inputs.DiskEncryptionPropertiesArgs @selfRef, global::System.String keyVersion)
    {
        @selfRef.KeyVersion = keyVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.Inputs.DiskEncryptionPropertiesArgs WithMsiResourceId(this global::Pulumi.AzureNative.HDInsight.Inputs.DiskEncryptionPropertiesArgs @selfRef, global::System.String msiResourceId)
    {
        @selfRef.MsiResourceId = msiResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.Inputs.DiskEncryptionPropertiesArgs WithVaultUri(this global::Pulumi.AzureNative.HDInsight.Inputs.DiskEncryptionPropertiesArgs @selfRef, global::System.String vaultUri)
    {
        @selfRef.VaultUri = vaultUri;
        return @selfRef;
    }

}
