// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.RecoveryServices.Inputs;

namespace Pulumi.AzureNative.RecoveryServices;

public static partial class RecoveryPlanProtectedItemArgsExtensions
{
    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.RecoveryPlanProtectedItemArgs WithId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.RecoveryPlanProtectedItemArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.RecoveryPlanProtectedItemArgs WithVirtualMachineId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.RecoveryPlanProtectedItemArgs @selfRef, global::System.String virtualMachineId)
    {
        @selfRef.VirtualMachineId = virtualMachineId;
        return @selfRef;
    }

}
