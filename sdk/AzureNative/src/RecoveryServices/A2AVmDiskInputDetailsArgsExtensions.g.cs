// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.RecoveryServices.Inputs;

namespace Pulumi.AzureNative.RecoveryServices;

public static partial class A2AVmDiskInputDetailsArgsExtensions
{
    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.A2AVmDiskInputDetailsArgs WithDiskUri(this global::Pulumi.AzureNative.RecoveryServices.Inputs.A2AVmDiskInputDetailsArgs @selfRef, global::System.String diskUri)
    {
        @selfRef.DiskUri = diskUri;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.A2AVmDiskInputDetailsArgs WithPrimaryStagingAzureStorageAccountId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.A2AVmDiskInputDetailsArgs @selfRef, global::System.String primaryStagingAzureStorageAccountId)
    {
        @selfRef.PrimaryStagingAzureStorageAccountId = primaryStagingAzureStorageAccountId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.A2AVmDiskInputDetailsArgs WithRecoveryAzureStorageAccountId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.A2AVmDiskInputDetailsArgs @selfRef, global::System.String recoveryAzureStorageAccountId)
    {
        @selfRef.RecoveryAzureStorageAccountId = recoveryAzureStorageAccountId;
        return @selfRef;
    }

}
