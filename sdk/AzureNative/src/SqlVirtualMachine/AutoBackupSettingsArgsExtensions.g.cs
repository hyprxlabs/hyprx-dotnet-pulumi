// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.SqlVirtualMachine.Inputs;

namespace Pulumi.AzureNative.SqlVirtualMachine;

public static partial class AutoBackupSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs WithBackupScheduleType(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.SqlVirtualMachine.BackupScheduleType> backupScheduleType)
    {
        @selfRef.BackupScheduleType = backupScheduleType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs WithBackupSystemDbs(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs @selfRef, bool backupSystemDbs = true)
    {
        @selfRef.BackupSystemDbs = backupSystemDbs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs WithDaysOfWeek(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.SqlVirtualMachine.AutoBackupDaysOfWeek>> daysOfWeek)
    {
        @selfRef.DaysOfWeek = daysOfWeek;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs WithDaysOfWeek(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.SqlVirtualMachine.AutoBackupDaysOfWeek>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.SqlVirtualMachine.AutoBackupDaysOfWeek>>();
        @configure(@list);
        @selfRef.DaysOfWeek = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs WithDaysOfWeek(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.SqlVirtualMachine.AutoBackupDaysOfWeek>>> @create)
    {
        @selfRef.DaysOfWeek = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs WithEnable(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs @selfRef, bool enable = true)
    {
        @selfRef.Enable = enable;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs WithEnableEncryption(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs @selfRef, bool enableEncryption = true)
    {
        @selfRef.EnableEncryption = enableEncryption;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs WithFullBackupFrequency(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.SqlVirtualMachine.FullBackupFrequencyType> fullBackupFrequency)
    {
        @selfRef.FullBackupFrequency = fullBackupFrequency;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs WithFullBackupStartTime(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs @selfRef, global::System.Int32 fullBackupStartTime)
    {
        @selfRef.FullBackupStartTime = fullBackupStartTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs WithFullBackupWindowHours(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs @selfRef, global::System.Int32 fullBackupWindowHours)
    {
        @selfRef.FullBackupWindowHours = fullBackupWindowHours;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs WithLogBackupFrequency(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs @selfRef, global::System.Int32 logBackupFrequency)
    {
        @selfRef.LogBackupFrequency = logBackupFrequency;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs WithPassword(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs @selfRef, global::System.String password)
    {
        @selfRef.Password = password;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs WithRetentionPeriod(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs @selfRef, global::System.Int32 retentionPeriod)
    {
        @selfRef.RetentionPeriod = retentionPeriod;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs WithStorageAccessKey(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs @selfRef, global::System.String storageAccessKey)
    {
        @selfRef.StorageAccessKey = storageAccessKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs WithStorageAccountUrl(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs @selfRef, global::System.String storageAccountUrl)
    {
        @selfRef.StorageAccountUrl = storageAccountUrl;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs WithStorageContainerName(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AutoBackupSettingsArgs @selfRef, global::System.String storageContainerName)
    {
        @selfRef.StorageContainerName = storageContainerName;
        return @selfRef;
    }

}
