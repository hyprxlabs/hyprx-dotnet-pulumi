// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.RecoveryServices.Inputs;

namespace Pulumi.AzureNative.RecoveryServices;

public static partial class InMageAzureV2PolicyInputArgsExtensions
{
    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.InMageAzureV2PolicyInputArgs WithAppConsistentFrequencyInMinutes(this global::Pulumi.AzureNative.RecoveryServices.Inputs.InMageAzureV2PolicyInputArgs @selfRef, global::System.Int32 appConsistentFrequencyInMinutes)
    {
        @selfRef.AppConsistentFrequencyInMinutes = appConsistentFrequencyInMinutes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.InMageAzureV2PolicyInputArgs WithCrashConsistentFrequencyInMinutes(this global::Pulumi.AzureNative.RecoveryServices.Inputs.InMageAzureV2PolicyInputArgs @selfRef, global::System.Int32 crashConsistentFrequencyInMinutes)
    {
        @selfRef.CrashConsistentFrequencyInMinutes = crashConsistentFrequencyInMinutes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.InMageAzureV2PolicyInputArgs WithInstanceType(this global::Pulumi.AzureNative.RecoveryServices.Inputs.InMageAzureV2PolicyInputArgs @selfRef, global::System.String instanceType)
    {
        @selfRef.InstanceType = instanceType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.InMageAzureV2PolicyInputArgs WithMultiVmSyncStatus(this global::Pulumi.AzureNative.RecoveryServices.Inputs.InMageAzureV2PolicyInputArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.RecoveryServices.SetMultiVmSyncStatus> multiVmSyncStatus)
    {
        @selfRef.MultiVmSyncStatus = multiVmSyncStatus;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.InMageAzureV2PolicyInputArgs WithRecoveryPointHistory(this global::Pulumi.AzureNative.RecoveryServices.Inputs.InMageAzureV2PolicyInputArgs @selfRef, global::System.Int32 recoveryPointHistory)
    {
        @selfRef.RecoveryPointHistory = recoveryPointHistory;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.InMageAzureV2PolicyInputArgs WithRecoveryPointThresholdInMinutes(this global::Pulumi.AzureNative.RecoveryServices.Inputs.InMageAzureV2PolicyInputArgs @selfRef, global::System.Int32 recoveryPointThresholdInMinutes)
    {
        @selfRef.RecoveryPointThresholdInMinutes = recoveryPointThresholdInMinutes;
        return @selfRef;
    }

}
