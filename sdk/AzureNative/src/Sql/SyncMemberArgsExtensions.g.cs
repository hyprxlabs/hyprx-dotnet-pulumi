// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Sql;

public static partial class SyncMemberArgsExtensions
{
    public static global::Pulumi.AzureNative.Sql.SyncMemberArgs WithDatabaseName(this global::Pulumi.AzureNative.Sql.SyncMemberArgs @selfRef, global::System.String databaseName)
    {
        @selfRef.DatabaseName = databaseName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.SyncMemberArgs WithDatabaseType(this global::Pulumi.AzureNative.Sql.SyncMemberArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Sql.SyncMemberDbType> databaseType)
    {
        @selfRef.DatabaseType = databaseType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.SyncMemberArgs WithPassword(this global::Pulumi.AzureNative.Sql.SyncMemberArgs @selfRef, global::System.String password)
    {
        @selfRef.Password = password;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.SyncMemberArgs WithResourceGroupName(this global::Pulumi.AzureNative.Sql.SyncMemberArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.SyncMemberArgs WithServerName(this global::Pulumi.AzureNative.Sql.SyncMemberArgs @selfRef, global::System.String serverName)
    {
        @selfRef.ServerName = serverName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.SyncMemberArgs WithSqlServerDatabaseId(this global::Pulumi.AzureNative.Sql.SyncMemberArgs @selfRef, global::System.String sqlServerDatabaseId)
    {
        @selfRef.SqlServerDatabaseId = sqlServerDatabaseId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.SyncMemberArgs WithSyncAgentId(this global::Pulumi.AzureNative.Sql.SyncMemberArgs @selfRef, global::System.String syncAgentId)
    {
        @selfRef.SyncAgentId = syncAgentId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.SyncMemberArgs WithSyncDirection(this global::Pulumi.AzureNative.Sql.SyncMemberArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Sql.SyncDirection> syncDirection)
    {
        @selfRef.SyncDirection = syncDirection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.SyncMemberArgs WithSyncGroupName(this global::Pulumi.AzureNative.Sql.SyncMemberArgs @selfRef, global::System.String syncGroupName)
    {
        @selfRef.SyncGroupName = syncGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.SyncMemberArgs WithSyncMemberAzureDatabaseResourceId(this global::Pulumi.AzureNative.Sql.SyncMemberArgs @selfRef, global::System.String syncMemberAzureDatabaseResourceId)
    {
        @selfRef.SyncMemberAzureDatabaseResourceId = syncMemberAzureDatabaseResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.SyncMemberArgs WithSyncMemberName(this global::Pulumi.AzureNative.Sql.SyncMemberArgs @selfRef, global::System.String syncMemberName)
    {
        @selfRef.SyncMemberName = syncMemberName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.SyncMemberArgs WithUsePrivateLinkConnection(this global::Pulumi.AzureNative.Sql.SyncMemberArgs @selfRef, bool usePrivateLinkConnection = true)
    {
        @selfRef.UsePrivateLinkConnection = usePrivateLinkConnection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.SyncMemberArgs WithUserName(this global::Pulumi.AzureNative.Sql.SyncMemberArgs @selfRef, global::System.String userName)
    {
        @selfRef.UserName = userName;
        return @selfRef;
    }

}
