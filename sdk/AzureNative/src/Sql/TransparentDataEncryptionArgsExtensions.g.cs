// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Sql;

public static partial class TransparentDataEncryptionArgsExtensions
{
    public static global::Pulumi.AzureNative.Sql.TransparentDataEncryptionArgs WithDatabaseName(this global::Pulumi.AzureNative.Sql.TransparentDataEncryptionArgs @selfRef, global::System.String databaseName)
    {
        @selfRef.DatabaseName = databaseName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.TransparentDataEncryptionArgs WithResourceGroupName(this global::Pulumi.AzureNative.Sql.TransparentDataEncryptionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.TransparentDataEncryptionArgs WithServerName(this global::Pulumi.AzureNative.Sql.TransparentDataEncryptionArgs @selfRef, global::System.String serverName)
    {
        @selfRef.ServerName = serverName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.TransparentDataEncryptionArgs WithState(this global::Pulumi.AzureNative.Sql.TransparentDataEncryptionArgs @selfRef, global::Pulumi.AzureNative.Sql.TransparentDataEncryptionState state)
    {
        @selfRef.State = state;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.TransparentDataEncryptionArgs WithState(this global::Pulumi.AzureNative.Sql.TransparentDataEncryptionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Sql.TransparentDataEncryptionState> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.Sql.TransparentDataEncryptionState>();
        @configure(@item);
        @selfRef.State = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.TransparentDataEncryptionArgs WithTdeName(this global::Pulumi.AzureNative.Sql.TransparentDataEncryptionArgs @selfRef, global::System.String tdeName)
    {
        @selfRef.TdeName = tdeName;
        return @selfRef;
    }

}
