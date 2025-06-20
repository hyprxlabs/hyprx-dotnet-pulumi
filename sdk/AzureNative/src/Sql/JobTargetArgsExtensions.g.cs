// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Sql.Inputs;

namespace Pulumi.AzureNative.Sql;

public static partial class JobTargetArgsExtensions
{
    public static global::Pulumi.AzureNative.Sql.Inputs.JobTargetArgs WithDatabaseName(this global::Pulumi.AzureNative.Sql.Inputs.JobTargetArgs @selfRef, global::System.String databaseName)
    {
        @selfRef.DatabaseName = databaseName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.Inputs.JobTargetArgs WithElasticPoolName(this global::Pulumi.AzureNative.Sql.Inputs.JobTargetArgs @selfRef, global::System.String elasticPoolName)
    {
        @selfRef.ElasticPoolName = elasticPoolName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.Inputs.JobTargetArgs WithMembershipType(this global::Pulumi.AzureNative.Sql.Inputs.JobTargetArgs @selfRef, global::Pulumi.AzureNative.Sql.JobTargetGroupMembershipType membershipType)
    {
        @selfRef.MembershipType = membershipType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.Inputs.JobTargetArgs WithMembershipType(this global::Pulumi.AzureNative.Sql.Inputs.JobTargetArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Sql.JobTargetGroupMembershipType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.Sql.JobTargetGroupMembershipType>();
        @configure(@item);
        @selfRef.MembershipType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.Inputs.JobTargetArgs WithRefreshCredential(this global::Pulumi.AzureNative.Sql.Inputs.JobTargetArgs @selfRef, global::System.String refreshCredential)
    {
        @selfRef.RefreshCredential = refreshCredential;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.Inputs.JobTargetArgs WithServerName(this global::Pulumi.AzureNative.Sql.Inputs.JobTargetArgs @selfRef, global::System.String serverName)
    {
        @selfRef.ServerName = serverName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.Inputs.JobTargetArgs WithShardMapName(this global::Pulumi.AzureNative.Sql.Inputs.JobTargetArgs @selfRef, global::System.String shardMapName)
    {
        @selfRef.ShardMapName = shardMapName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.Inputs.JobTargetArgs WithType(this global::Pulumi.AzureNative.Sql.Inputs.JobTargetArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Sql.JobTargetType> type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
