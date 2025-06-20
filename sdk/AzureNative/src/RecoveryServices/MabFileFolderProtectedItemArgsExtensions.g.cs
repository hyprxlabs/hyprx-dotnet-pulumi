// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.RecoveryServices.Inputs;

namespace Pulumi.AzureNative.RecoveryServices;

public static partial class MabFileFolderProtectedItemArgsExtensions
{
    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithBackupSetName(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.String backupSetName)
    {
        @selfRef.BackupSetName = backupSetName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithComputerName(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.String computerName)
    {
        @selfRef.ComputerName = computerName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithContainerName(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.String containerName)
    {
        @selfRef.ContainerName = containerName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithCreateMode(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.RecoveryServices.CreateMode> createMode)
    {
        @selfRef.CreateMode = createMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithDeferredDeleteSyncTimeInUTC(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.Double deferredDeleteSyncTimeInUTC)
    {
        @selfRef.DeferredDeleteSyncTimeInUTC = deferredDeleteSyncTimeInUTC;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithDeferredDeleteTimeInUTC(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.String deferredDeleteTimeInUTC)
    {
        @selfRef.DeferredDeleteTimeInUTC = deferredDeleteTimeInUTC;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithDeferredDeleteTimeRemaining(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.String deferredDeleteTimeRemaining)
    {
        @selfRef.DeferredDeleteTimeRemaining = deferredDeleteTimeRemaining;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithExtendedInfo(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemExtendedInfoArgs extendedInfo)
    {
        @selfRef.ExtendedInfo = extendedInfo;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithExtendedInfo(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemExtendedInfoArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemExtendedInfoArgs();
        @configure(@item);
        @selfRef.ExtendedInfo = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithFriendlyName(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.String friendlyName)
    {
        @selfRef.FriendlyName = friendlyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithIsArchiveEnabled(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, bool isArchiveEnabled = true)
    {
        @selfRef.IsArchiveEnabled = isArchiveEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithIsDeferredDeleteScheduleUpcoming(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, bool isDeferredDeleteScheduleUpcoming = true)
    {
        @selfRef.IsDeferredDeleteScheduleUpcoming = isDeferredDeleteScheduleUpcoming;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithIsRehydrate(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, bool isRehydrate = true)
    {
        @selfRef.IsRehydrate = isRehydrate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithIsScheduledForDeferredDelete(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, bool isScheduledForDeferredDelete = true)
    {
        @selfRef.IsScheduledForDeferredDelete = isScheduledForDeferredDelete;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithLastBackupStatus(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.String lastBackupStatus)
    {
        @selfRef.LastBackupStatus = lastBackupStatus;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithLastBackupTime(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.String lastBackupTime)
    {
        @selfRef.LastBackupTime = lastBackupTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithLastRecoveryPoint(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.String lastRecoveryPoint)
    {
        @selfRef.LastRecoveryPoint = lastRecoveryPoint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithPolicyId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.String policyId)
    {
        @selfRef.PolicyId = policyId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithPolicyName(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.String policyName)
    {
        @selfRef.PolicyName = policyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithProtectedItemType(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.String protectedItemType)
    {
        @selfRef.ProtectedItemType = protectedItemType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithProtectionState(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.String protectionState)
    {
        @selfRef.ProtectionState = protectionState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithResourceGuardOperationRequests(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.Collections.Generic.List<global::System.String> resourceGuardOperationRequests)
    {
        @selfRef.ResourceGuardOperationRequests = resourceGuardOperationRequests;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithResourceGuardOperationRequests(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ResourceGuardOperationRequests = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithResourceGuardOperationRequests(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ResourceGuardOperationRequests = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithSoftDeleteRetentionPeriodInDays(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.Int32 softDeleteRetentionPeriodInDays)
    {
        @selfRef.SoftDeleteRetentionPeriodInDays = softDeleteRetentionPeriodInDays;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs WithSourceResourceId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.MabFileFolderProtectedItemArgs @selfRef, global::System.String sourceResourceId)
    {
        @selfRef.SourceResourceId = sourceResourceId;
        return @selfRef;
    }

}
