// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AzureStackHCI.Inputs;

namespace Pulumi.AzureNative.AzureStackHCI;

public static partial class VirtualMachineInstancePropertiesStorageProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstancePropertiesStorageProfileArgs WithDataDisks(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstancePropertiesStorageProfileArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualHardDiskArmReferenceArgs> dataDisks)
    {
        @selfRef.DataDisks = dataDisks;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstancePropertiesStorageProfileArgs WithDataDisks(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstancePropertiesStorageProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualHardDiskArmReferenceArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualHardDiskArmReferenceArgs>();
        @configure(@list);
        @selfRef.DataDisks = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstancePropertiesStorageProfileArgs WithDataDisks(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstancePropertiesStorageProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualHardDiskArmReferenceArgs>> @create)
    {
        @selfRef.DataDisks = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstancePropertiesStorageProfileArgs WithImageReference(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstancePropertiesStorageProfileArgs @selfRef, global::Pulumi.AzureNative.AzureStackHCI.Inputs.ImageArmReferenceArgs imageReference)
    {
        @selfRef.ImageReference = imageReference;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstancePropertiesStorageProfileArgs WithImageReference(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstancePropertiesStorageProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureStackHCI.Inputs.ImageArmReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureStackHCI.Inputs.ImageArmReferenceArgs();
        @configure(@item);
        @selfRef.ImageReference = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstancePropertiesStorageProfileArgs WithOsDisk(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstancePropertiesStorageProfileArgs @selfRef, global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstancePropertiesStorageProfileOsDiskArgs osDisk)
    {
        @selfRef.OsDisk = osDisk;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstancePropertiesStorageProfileArgs WithOsDisk(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstancePropertiesStorageProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstancePropertiesStorageProfileOsDiskArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstancePropertiesStorageProfileOsDiskArgs();
        @configure(@item);
        @selfRef.OsDisk = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstancePropertiesStorageProfileArgs WithVmConfigStoragePathId(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.VirtualMachineInstancePropertiesStorageProfileArgs @selfRef, global::System.String vmConfigStoragePathId)
    {
        @selfRef.VmConfigStoragePathId = vmConfigStoragePathId;
        return @selfRef;
    }

}
