// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Web;

public static partial class WebAppBackupConfigurationSlotArgsExtensions
{
    public static global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs WithBackupName(this global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs @selfRef, global::System.String backupName)
    {
        @selfRef.BackupName = backupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs WithBackupSchedule(this global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs @selfRef, global::Pulumi.AzureNative.Web.Inputs.BackupScheduleArgs backupSchedule)
    {
        @selfRef.BackupSchedule = backupSchedule;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs WithBackupSchedule(this global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Web.Inputs.BackupScheduleArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Web.Inputs.BackupScheduleArgs();
        @configure(@item);
        @selfRef.BackupSchedule = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs WithDatabases(this global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Web.Inputs.DatabaseBackupSettingArgs> databases)
    {
        @selfRef.Databases = databases;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs WithDatabases(this global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Web.Inputs.DatabaseBackupSettingArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Web.Inputs.DatabaseBackupSettingArgs>();
        @configure(@list);
        @selfRef.Databases = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs WithDatabases(this global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Web.Inputs.DatabaseBackupSettingArgs>> @create)
    {
        @selfRef.Databases = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs WithEnabled(this global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs WithKind(this global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs @selfRef, global::System.String kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs WithName(this global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs WithResourceGroupName(this global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs WithSlot(this global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs @selfRef, global::System.String slot)
    {
        @selfRef.Slot = slot;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs WithStorageAccountUrl(this global::Pulumi.AzureNative.Web.WebAppBackupConfigurationSlotArgs @selfRef, global::System.String storageAccountUrl)
    {
        @selfRef.StorageAccountUrl = storageAccountUrl;
        return @selfRef;
    }

}
