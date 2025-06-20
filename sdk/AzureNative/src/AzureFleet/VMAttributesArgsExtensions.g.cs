// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AzureFleet.Inputs;

namespace Pulumi.AzureNative.AzureFleet;

public static partial class VMAttributesArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithAcceleratorCount(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxIntegerArgs acceleratorCount)
    {
        @selfRef.AcceleratorCount = acceleratorCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithAcceleratorCount(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxIntegerArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxIntegerArgs();
        @configure(@item);
        @selfRef.AcceleratorCount = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithAcceleratorManufacturers(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.AcceleratorManufacturer>> acceleratorManufacturers)
    {
        @selfRef.AcceleratorManufacturers = acceleratorManufacturers;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithAcceleratorManufacturers(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.AcceleratorManufacturer>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.AcceleratorManufacturer>>();
        @configure(@list);
        @selfRef.AcceleratorManufacturers = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithAcceleratorManufacturers(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.AcceleratorManufacturer>>> @create)
    {
        @selfRef.AcceleratorManufacturers = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithAcceleratorSupport(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.VMAttributeSupport> acceleratorSupport)
    {
        @selfRef.AcceleratorSupport = acceleratorSupport;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithAcceleratorTypes(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.AcceleratorType>> acceleratorTypes)
    {
        @selfRef.AcceleratorTypes = acceleratorTypes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithAcceleratorTypes(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.AcceleratorType>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.AcceleratorType>>();
        @configure(@list);
        @selfRef.AcceleratorTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithAcceleratorTypes(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.AcceleratorType>>> @create)
    {
        @selfRef.AcceleratorTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithArchitectureTypes(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.ArchitectureType>> architectureTypes)
    {
        @selfRef.ArchitectureTypes = architectureTypes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithArchitectureTypes(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.ArchitectureType>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.ArchitectureType>>();
        @configure(@list);
        @selfRef.ArchitectureTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithArchitectureTypes(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.ArchitectureType>>> @create)
    {
        @selfRef.ArchitectureTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithBurstableSupport(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.VMAttributeSupport> burstableSupport)
    {
        @selfRef.BurstableSupport = burstableSupport;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithCpuManufacturers(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.CpuManufacturer>> cpuManufacturers)
    {
        @selfRef.CpuManufacturers = cpuManufacturers;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithCpuManufacturers(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.CpuManufacturer>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.CpuManufacturer>>();
        @configure(@list);
        @selfRef.CpuManufacturers = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithCpuManufacturers(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.CpuManufacturer>>> @create)
    {
        @selfRef.CpuManufacturers = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithDataDiskCount(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxIntegerArgs dataDiskCount)
    {
        @selfRef.DataDiskCount = dataDiskCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithDataDiskCount(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxIntegerArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxIntegerArgs();
        @configure(@item);
        @selfRef.DataDiskCount = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithExcludedVMSizes(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> excludedVMSizes)
    {
        @selfRef.ExcludedVMSizes = excludedVMSizes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithExcludedVMSizes(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ExcludedVMSizes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithExcludedVMSizes(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ExcludedVMSizes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithLocalStorageDiskTypes(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.LocalStorageDiskType>> localStorageDiskTypes)
    {
        @selfRef.LocalStorageDiskTypes = localStorageDiskTypes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithLocalStorageDiskTypes(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.LocalStorageDiskType>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.LocalStorageDiskType>>();
        @configure(@list);
        @selfRef.LocalStorageDiskTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithLocalStorageDiskTypes(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.LocalStorageDiskType>>> @create)
    {
        @selfRef.LocalStorageDiskTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithLocalStorageInGiB(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxDoubleArgs localStorageInGiB)
    {
        @selfRef.LocalStorageInGiB = localStorageInGiB;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithLocalStorageInGiB(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxDoubleArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxDoubleArgs();
        @configure(@item);
        @selfRef.LocalStorageInGiB = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithLocalStorageSupport(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.VMAttributeSupport> localStorageSupport)
    {
        @selfRef.LocalStorageSupport = localStorageSupport;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithMemoryInGiB(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxDoubleArgs memoryInGiB)
    {
        @selfRef.MemoryInGiB = memoryInGiB;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithMemoryInGiB(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxDoubleArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxDoubleArgs();
        @configure(@item);
        @selfRef.MemoryInGiB = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithMemoryInGiBPerVCpu(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxDoubleArgs memoryInGiBPerVCpu)
    {
        @selfRef.MemoryInGiBPerVCpu = memoryInGiBPerVCpu;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithMemoryInGiBPerVCpu(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxDoubleArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxDoubleArgs();
        @configure(@item);
        @selfRef.MemoryInGiBPerVCpu = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithNetworkBandwidthInMbps(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxDoubleArgs networkBandwidthInMbps)
    {
        @selfRef.NetworkBandwidthInMbps = networkBandwidthInMbps;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithNetworkBandwidthInMbps(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxDoubleArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxDoubleArgs();
        @configure(@item);
        @selfRef.NetworkBandwidthInMbps = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithNetworkInterfaceCount(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxIntegerArgs networkInterfaceCount)
    {
        @selfRef.NetworkInterfaceCount = networkInterfaceCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithNetworkInterfaceCount(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxIntegerArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxIntegerArgs();
        @configure(@item);
        @selfRef.NetworkInterfaceCount = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithRdmaNetworkInterfaceCount(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxIntegerArgs rdmaNetworkInterfaceCount)
    {
        @selfRef.RdmaNetworkInterfaceCount = rdmaNetworkInterfaceCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithRdmaNetworkInterfaceCount(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxIntegerArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxIntegerArgs();
        @configure(@item);
        @selfRef.RdmaNetworkInterfaceCount = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithRdmaSupport(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.VMAttributeSupport> rdmaSupport)
    {
        @selfRef.RdmaSupport = rdmaSupport;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithVCpuCount(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxIntegerArgs vCpuCount)
    {
        @selfRef.VCpuCount = vCpuCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithVCpuCount(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxIntegerArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributeMinMaxIntegerArgs();
        @configure(@item);
        @selfRef.VCpuCount = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithVmCategories(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.VMCategory>> vmCategories)
    {
        @selfRef.VmCategories = vmCategories;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithVmCategories(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.VMCategory>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.VMCategory>>();
        @configure(@list);
        @selfRef.VmCategories = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs WithVmCategories(this global::Pulumi.AzureNative.AzureFleet.Inputs.VMAttributesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureFleet.VMCategory>>> @create)
    {
        @selfRef.VmCategories = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
