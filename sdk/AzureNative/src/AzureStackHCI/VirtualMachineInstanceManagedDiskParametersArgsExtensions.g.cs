// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AzureStackHCI.Inputs;

namespace Pulumi.AzureNative.AzureStackHCI;

public static partial class VirtualMachineInstanceManagedDiskParametersArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstanceManagedDiskParametersArgs WithSecurityProfile(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstanceManagedDiskParametersArgs @selfRef, global::Pulumi.AzureNative.AzureStackHCI.Inputs.VMDiskSecurityProfileArgs securityProfile)
    {
        @selfRef.SecurityProfile = securityProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstanceManagedDiskParametersArgs WithSecurityProfile(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstanceManagedDiskParametersArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureStackHCI.Inputs.VMDiskSecurityProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureStackHCI.Inputs.VMDiskSecurityProfileArgs();
        @configure(@item);
        @selfRef.SecurityProfile = @item;
        return @selfRef;
    }

}
