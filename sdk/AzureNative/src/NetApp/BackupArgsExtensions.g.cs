// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.NetApp;

public static partial class BackupArgsExtensions
{
    public static global::Pulumi.AzureNative.NetApp.BackupArgs WithAccountName(this global::Pulumi.AzureNative.NetApp.BackupArgs @selfRef, global::System.String accountName)
    {
        @selfRef.AccountName = accountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.BackupArgs WithBackupName(this global::Pulumi.AzureNative.NetApp.BackupArgs @selfRef, global::System.String backupName)
    {
        @selfRef.BackupName = backupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.BackupArgs WithBackupVaultName(this global::Pulumi.AzureNative.NetApp.BackupArgs @selfRef, global::System.String backupVaultName)
    {
        @selfRef.BackupVaultName = backupVaultName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.BackupArgs WithLabel(this global::Pulumi.AzureNative.NetApp.BackupArgs @selfRef, global::System.String label)
    {
        @selfRef.Label = label;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.BackupArgs WithResourceGroupName(this global::Pulumi.AzureNative.NetApp.BackupArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.BackupArgs WithSnapshotName(this global::Pulumi.AzureNative.NetApp.BackupArgs @selfRef, global::System.String snapshotName)
    {
        @selfRef.SnapshotName = snapshotName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.BackupArgs WithUseExistingSnapshot(this global::Pulumi.AzureNative.NetApp.BackupArgs @selfRef, bool useExistingSnapshot = true)
    {
        @selfRef.UseExistingSnapshot = useExistingSnapshot;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.BackupArgs WithVolumeResourceId(this global::Pulumi.AzureNative.NetApp.BackupArgs @selfRef, global::System.String volumeResourceId)
    {
        @selfRef.VolumeResourceId = volumeResourceId;
        return @selfRef;
    }

}
