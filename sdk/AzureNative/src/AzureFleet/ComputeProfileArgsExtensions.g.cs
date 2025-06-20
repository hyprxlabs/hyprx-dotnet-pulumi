// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AzureFleet.Inputs;

namespace Pulumi.AzureNative.AzureFleet;

public static partial class ComputeProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureFleet.Inputs.ComputeProfileArgs WithAdditionalVirtualMachineCapabilities(this global::Pulumi.AzureNative.AzureFleet.Inputs.ComputeProfileArgs @selfRef, global::Pulumi.AzureNative.AzureFleet.Inputs.AdditionalCapabilitiesArgs additionalVirtualMachineCapabilities)
    {
        @selfRef.AdditionalVirtualMachineCapabilities = additionalVirtualMachineCapabilities;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.ComputeProfileArgs WithAdditionalVirtualMachineCapabilities(this global::Pulumi.AzureNative.AzureFleet.Inputs.ComputeProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureFleet.Inputs.AdditionalCapabilitiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureFleet.Inputs.AdditionalCapabilitiesArgs();
        @configure(@item);
        @selfRef.AdditionalVirtualMachineCapabilities = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.ComputeProfileArgs WithBaseVirtualMachineProfile(this global::Pulumi.AzureNative.AzureFleet.Inputs.ComputeProfileArgs @selfRef, global::Pulumi.AzureNative.AzureFleet.Inputs.BaseVirtualMachineProfileArgs baseVirtualMachineProfile)
    {
        @selfRef.BaseVirtualMachineProfile = baseVirtualMachineProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.ComputeProfileArgs WithBaseVirtualMachineProfile(this global::Pulumi.AzureNative.AzureFleet.Inputs.ComputeProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureFleet.Inputs.BaseVirtualMachineProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureFleet.Inputs.BaseVirtualMachineProfileArgs();
        @configure(@item);
        @selfRef.BaseVirtualMachineProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.ComputeProfileArgs WithComputeApiVersion(this global::Pulumi.AzureNative.AzureFleet.Inputs.ComputeProfileArgs @selfRef, global::System.String computeApiVersion)
    {
        @selfRef.ComputeApiVersion = computeApiVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.ComputeProfileArgs WithPlatformFaultDomainCount(this global::Pulumi.AzureNative.AzureFleet.Inputs.ComputeProfileArgs @selfRef, global::System.Int32 platformFaultDomainCount)
    {
        @selfRef.PlatformFaultDomainCount = platformFaultDomainCount;
        return @selfRef;
    }

}
