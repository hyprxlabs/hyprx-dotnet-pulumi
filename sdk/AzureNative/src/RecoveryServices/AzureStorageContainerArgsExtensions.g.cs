// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.RecoveryServices.Inputs;

namespace Pulumi.AzureNative.RecoveryServices;

public static partial class AzureStorageContainerArgsExtensions
{
    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs WithAcquireStorageAccountLock(this global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.RecoveryServices.AcquireStorageAccountLock> acquireStorageAccountLock)
    {
        @selfRef.AcquireStorageAccountLock = acquireStorageAccountLock;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs WithBackupManagementType(this global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.RecoveryServices.BackupManagementType> backupManagementType)
    {
        @selfRef.BackupManagementType = backupManagementType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs WithContainerType(this global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs @selfRef, global::System.String containerType)
    {
        @selfRef.ContainerType = containerType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs WithFriendlyName(this global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs @selfRef, global::System.String friendlyName)
    {
        @selfRef.FriendlyName = friendlyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs WithHealthStatus(this global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs @selfRef, global::System.String healthStatus)
    {
        @selfRef.HealthStatus = healthStatus;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs WithOperationType(this global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.RecoveryServices.OperationType> operationType)
    {
        @selfRef.OperationType = operationType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs WithProtectableObjectType(this global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs @selfRef, global::System.String protectableObjectType)
    {
        @selfRef.ProtectableObjectType = protectableObjectType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs WithProtectedItemCount(this global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs @selfRef, global::System.Double protectedItemCount)
    {
        @selfRef.ProtectedItemCount = protectedItemCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs WithRegistrationStatus(this global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs @selfRef, global::System.String registrationStatus)
    {
        @selfRef.RegistrationStatus = registrationStatus;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs WithResourceGroup(this global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs @selfRef, global::System.String resourceGroup)
    {
        @selfRef.ResourceGroup = resourceGroup;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs WithSourceResourceId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs @selfRef, global::System.String sourceResourceId)
    {
        @selfRef.SourceResourceId = sourceResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs WithStorageAccountVersion(this global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureStorageContainerArgs @selfRef, global::System.String storageAccountVersion)
    {
        @selfRef.StorageAccountVersion = storageAccountVersion;
        return @selfRef;
    }

}
