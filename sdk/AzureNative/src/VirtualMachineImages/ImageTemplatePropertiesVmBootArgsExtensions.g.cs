// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.VirtualMachineImages.Inputs;

namespace Pulumi.AzureNative.VirtualMachineImages;

public static partial class ImageTemplatePropertiesVmBootArgsExtensions
{
    public static global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePropertiesVmBootArgs WithState(this global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePropertiesVmBootArgs @selfRef, global::Pulumi.AzureNative.VirtualMachineImages.VMBootOptimizationState state)
    {
        @selfRef.State = state;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePropertiesVmBootArgs WithState(this global::Pulumi.AzureNative.VirtualMachineImages.Inputs.ImageTemplatePropertiesVmBootArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.VirtualMachineImages.VMBootOptimizationState> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.VirtualMachineImages.VMBootOptimizationState>();
        @configure(@item);
        @selfRef.State = @item;
        return @selfRef;
    }

}
