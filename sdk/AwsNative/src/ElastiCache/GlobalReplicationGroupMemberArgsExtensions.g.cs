// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ElastiCache.Inputs;

namespace Pulumi.AwsNative.ElastiCache;

public static partial class GlobalReplicationGroupMemberArgsExtensions
{
    public static global::Pulumi.AwsNative.ElastiCache.Inputs.GlobalReplicationGroupMemberArgs WithReplicationGroupId(this global::Pulumi.AwsNative.ElastiCache.Inputs.GlobalReplicationGroupMemberArgs @selfRef, global::System.String replicationGroupId)
    {
        @selfRef.ReplicationGroupId = replicationGroupId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElastiCache.Inputs.GlobalReplicationGroupMemberArgs WithReplicationGroupRegion(this global::Pulumi.AwsNative.ElastiCache.Inputs.GlobalReplicationGroupMemberArgs @selfRef, global::System.String replicationGroupRegion)
    {
        @selfRef.ReplicationGroupRegion = replicationGroupRegion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElastiCache.Inputs.GlobalReplicationGroupMemberArgs WithRole(this global::Pulumi.AwsNative.ElastiCache.Inputs.GlobalReplicationGroupMemberArgs @selfRef, global::Pulumi.AwsNative.ElastiCache.GlobalReplicationGroupMemberRole role)
    {
        @selfRef.Role = role;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ElastiCache.Inputs.GlobalReplicationGroupMemberArgs WithRole(this global::Pulumi.AwsNative.ElastiCache.Inputs.GlobalReplicationGroupMemberArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ElastiCache.GlobalReplicationGroupMemberRole> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.ElastiCache.GlobalReplicationGroupMemberRole>();
        @configure(@item);
        @selfRef.Role = @item;
        return @selfRef;
    }

}
