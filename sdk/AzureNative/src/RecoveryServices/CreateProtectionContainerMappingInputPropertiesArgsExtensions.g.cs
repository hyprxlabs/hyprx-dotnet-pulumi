// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.RecoveryServices.Inputs;

namespace Pulumi.AzureNative.RecoveryServices;

public static partial class CreateProtectionContainerMappingInputPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.CreateProtectionContainerMappingInputPropertiesArgs WithPolicyId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.CreateProtectionContainerMappingInputPropertiesArgs @selfRef, global::System.String policyId)
    {
        @selfRef.PolicyId = policyId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.CreateProtectionContainerMappingInputPropertiesArgs WithProviderSpecificInput(this global::Pulumi.AzureNative.RecoveryServices.Inputs.CreateProtectionContainerMappingInputPropertiesArgs @selfRef, global::Pulumi.Union<global::Pulumi.AzureNative.RecoveryServices.Inputs.A2AContainerMappingInputArgs, global::Pulumi.AzureNative.RecoveryServices.Inputs.VMwareCbtContainerMappingInputArgs> providerSpecificInput)
    {
        @selfRef.ProviderSpecificInput = providerSpecificInput;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.CreateProtectionContainerMappingInputPropertiesArgs WithTargetProtectionContainerId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.CreateProtectionContainerMappingInputPropertiesArgs @selfRef, global::System.String targetProtectionContainerId)
    {
        @selfRef.TargetProtectionContainerId = targetProtectionContainerId;
        return @selfRef;
    }

}
