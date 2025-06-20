// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.CosmosDB.Inputs;

namespace Pulumi.AzureNative.CosmosDB;

public static partial class BackupPolicyMigrationStateArgsExtensions
{
    public static global::Pulumi.AzureNative.CosmosDB.Inputs.BackupPolicyMigrationStateArgs WithStartTime(this global::Pulumi.AzureNative.CosmosDB.Inputs.BackupPolicyMigrationStateArgs @selfRef, global::System.String startTime)
    {
        @selfRef.StartTime = startTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CosmosDB.Inputs.BackupPolicyMigrationStateArgs WithStatus(this global::Pulumi.AzureNative.CosmosDB.Inputs.BackupPolicyMigrationStateArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.CosmosDB.BackupPolicyMigrationStatus> status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CosmosDB.Inputs.BackupPolicyMigrationStateArgs WithTargetType(this global::Pulumi.AzureNative.CosmosDB.Inputs.BackupPolicyMigrationStateArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.CosmosDB.BackupPolicyType> targetType)
    {
        @selfRef.TargetType = targetType;
        return @selfRef;
    }

}
