// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.CosmosDB.Inputs;

namespace Pulumi.AzureNative.CosmosDB;

public static partial class PeriodicModePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.CosmosDB.Inputs.PeriodicModePropertiesArgs WithBackupIntervalInMinutes(this global::Pulumi.AzureNative.CosmosDB.Inputs.PeriodicModePropertiesArgs @selfRef, global::System.Int32 backupIntervalInMinutes)
    {
        @selfRef.BackupIntervalInMinutes = backupIntervalInMinutes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CosmosDB.Inputs.PeriodicModePropertiesArgs WithBackupRetentionIntervalInHours(this global::Pulumi.AzureNative.CosmosDB.Inputs.PeriodicModePropertiesArgs @selfRef, global::System.Int32 backupRetentionIntervalInHours)
    {
        @selfRef.BackupRetentionIntervalInHours = backupRetentionIntervalInHours;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CosmosDB.Inputs.PeriodicModePropertiesArgs WithBackupStorageRedundancy(this global::Pulumi.AzureNative.CosmosDB.Inputs.PeriodicModePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.CosmosDB.BackupStorageRedundancy> backupStorageRedundancy)
    {
        @selfRef.BackupStorageRedundancy = backupStorageRedundancy;
        return @selfRef;
    }

}
