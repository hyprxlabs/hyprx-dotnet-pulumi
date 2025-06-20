// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Sql;

public static partial class EncryptionProtectorArgsExtensions
{
    public static global::Pulumi.AzureNative.Sql.EncryptionProtectorArgs WithAutoRotationEnabled(this global::Pulumi.AzureNative.Sql.EncryptionProtectorArgs @selfRef, bool autoRotationEnabled = true)
    {
        @selfRef.AutoRotationEnabled = autoRotationEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.EncryptionProtectorArgs WithEncryptionProtectorName(this global::Pulumi.AzureNative.Sql.EncryptionProtectorArgs @selfRef, global::System.String encryptionProtectorName)
    {
        @selfRef.EncryptionProtectorName = encryptionProtectorName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.EncryptionProtectorArgs WithResourceGroupName(this global::Pulumi.AzureNative.Sql.EncryptionProtectorArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.EncryptionProtectorArgs WithServerKeyName(this global::Pulumi.AzureNative.Sql.EncryptionProtectorArgs @selfRef, global::System.String serverKeyName)
    {
        @selfRef.ServerKeyName = serverKeyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.EncryptionProtectorArgs WithServerKeyType(this global::Pulumi.AzureNative.Sql.EncryptionProtectorArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Sql.ServerKeyType> serverKeyType)
    {
        @selfRef.ServerKeyType = serverKeyType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.EncryptionProtectorArgs WithServerName(this global::Pulumi.AzureNative.Sql.EncryptionProtectorArgs @selfRef, global::System.String serverName)
    {
        @selfRef.ServerName = serverName;
        return @selfRef;
    }

}
