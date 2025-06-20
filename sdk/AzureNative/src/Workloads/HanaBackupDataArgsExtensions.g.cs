// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Workloads.Inputs;

namespace Pulumi.AzureNative.Workloads;

public static partial class HanaBackupDataArgsExtensions
{
    public static global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs WithBackupPolicy(this global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs @selfRef, global::Pulumi.AzureNative.Workloads.Inputs.DBBackupPolicyPropertiesArgs backupPolicy)
    {
        @selfRef.BackupPolicy = backupPolicy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs WithBackupPolicy(this global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Workloads.Inputs.DBBackupPolicyPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Workloads.Inputs.DBBackupPolicyPropertiesArgs();
        @configure(@item);
        @selfRef.BackupPolicy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs WithBackupType(this global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs @selfRef, global::System.String backupType)
    {
        @selfRef.BackupType = backupType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs WithDbInstanceSnapshotBackupPolicy(this global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs @selfRef, global::Pulumi.AzureNative.Workloads.Inputs.DBBackupPolicyPropertiesArgs dbInstanceSnapshotBackupPolicy)
    {
        @selfRef.DbInstanceSnapshotBackupPolicy = dbInstanceSnapshotBackupPolicy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs WithDbInstanceSnapshotBackupPolicy(this global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Workloads.Inputs.DBBackupPolicyPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Workloads.Inputs.DBBackupPolicyPropertiesArgs();
        @configure(@item);
        @selfRef.DbInstanceSnapshotBackupPolicy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs WithHdbuserstoreKeyName(this global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs @selfRef, global::System.String hdbuserstoreKeyName)
    {
        @selfRef.HdbuserstoreKeyName = hdbuserstoreKeyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs WithInstanceNumber(this global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs @selfRef, global::System.String instanceNumber)
    {
        @selfRef.InstanceNumber = instanceNumber;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs WithRecoveryServicesVault(this global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs @selfRef, global::Pulumi.Union<global::Pulumi.AzureNative.Workloads.Inputs.ExistingRecoveryServicesVaultArgs, global::Pulumi.AzureNative.Workloads.Inputs.NewRecoveryServicesVaultArgs> recoveryServicesVault)
    {
        @selfRef.RecoveryServicesVault = recoveryServicesVault;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs WithSslConfiguration(this global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs @selfRef, global::Pulumi.AzureNative.Workloads.Inputs.SSLConfigurationArgs sslConfiguration)
    {
        @selfRef.SslConfiguration = sslConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs WithSslConfiguration(this global::Pulumi.AzureNative.Workloads.Inputs.HanaBackupDataArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Workloads.Inputs.SSLConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Workloads.Inputs.SSLConfigurationArgs();
        @configure(@item);
        @selfRef.SslConfiguration = @item;
        return @selfRef;
    }

}
