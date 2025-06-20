// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.RecoveryServices.Inputs;

namespace Pulumi.AzureNative.RecoveryServices;

public static partial class AzureSqlContainerArgsExtensions
{
    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureSqlContainerArgs WithBackupManagementType(this global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureSqlContainerArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.RecoveryServices.BackupManagementType> backupManagementType)
    {
        @selfRef.BackupManagementType = backupManagementType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureSqlContainerArgs WithContainerType(this global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureSqlContainerArgs @selfRef, global::System.String containerType)
    {
        @selfRef.ContainerType = containerType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureSqlContainerArgs WithFriendlyName(this global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureSqlContainerArgs @selfRef, global::System.String friendlyName)
    {
        @selfRef.FriendlyName = friendlyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureSqlContainerArgs WithHealthStatus(this global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureSqlContainerArgs @selfRef, global::System.String healthStatus)
    {
        @selfRef.HealthStatus = healthStatus;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureSqlContainerArgs WithProtectableObjectType(this global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureSqlContainerArgs @selfRef, global::System.String protectableObjectType)
    {
        @selfRef.ProtectableObjectType = protectableObjectType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureSqlContainerArgs WithRegistrationStatus(this global::Pulumi.AzureNative.RecoveryServices.Inputs.AzureSqlContainerArgs @selfRef, global::System.String registrationStatus)
    {
        @selfRef.RegistrationStatus = registrationStatus;
        return @selfRef;
    }

}
