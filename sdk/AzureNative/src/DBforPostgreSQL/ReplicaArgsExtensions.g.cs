// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DBforPostgreSQL.Inputs;

namespace Pulumi.AzureNative.DBforPostgreSQL;

public static partial class ReplicaArgsExtensions
{
    public static global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ReplicaArgs WithPromoteMode(this global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ReplicaArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DBforPostgreSQL.ReadReplicaPromoteMode> promoteMode)
    {
        @selfRef.PromoteMode = promoteMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ReplicaArgs WithPromoteOption(this global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ReplicaArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DBforPostgreSQL.ReplicationPromoteOption> promoteOption)
    {
        @selfRef.PromoteOption = promoteOption;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ReplicaArgs WithRole(this global::Pulumi.AzureNative.DBforPostgreSQL.Inputs.ReplicaArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DBforPostgreSQL.ReplicationRole> role)
    {
        @selfRef.Role = role;
        return @selfRef;
    }

}
