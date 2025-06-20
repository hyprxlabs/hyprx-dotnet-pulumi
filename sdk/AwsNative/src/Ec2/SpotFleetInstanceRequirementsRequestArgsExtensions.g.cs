// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class SpotFleetInstanceRequirementsRequestArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithAcceleratorCount(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetAcceleratorCountRequestArgs acceleratorCount)
    {
        @selfRef.AcceleratorCount = acceleratorCount;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithAcceleratorCount(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetAcceleratorCountRequestArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetAcceleratorCountRequestArgs();
        @configure(@item);
        @selfRef.AcceleratorCount = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithAcceleratorManufacturers(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestAcceleratorManufacturersItem> acceleratorManufacturers)
    {
        @selfRef.AcceleratorManufacturers = acceleratorManufacturers;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithAcceleratorManufacturers(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestAcceleratorManufacturersItem>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestAcceleratorManufacturersItem>();
        @configure(@list);
        @selfRef.AcceleratorManufacturers = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithAcceleratorManufacturers(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestAcceleratorManufacturersItem>> @create)
    {
        @selfRef.AcceleratorManufacturers = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithAcceleratorNames(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestAcceleratorNamesItem> acceleratorNames)
    {
        @selfRef.AcceleratorNames = acceleratorNames;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithAcceleratorNames(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestAcceleratorNamesItem>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestAcceleratorNamesItem>();
        @configure(@list);
        @selfRef.AcceleratorNames = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithAcceleratorNames(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestAcceleratorNamesItem>> @create)
    {
        @selfRef.AcceleratorNames = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithAcceleratorTotalMemoryMiB(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetAcceleratorTotalMemoryMiBRequestArgs acceleratorTotalMemoryMiB)
    {
        @selfRef.AcceleratorTotalMemoryMiB = acceleratorTotalMemoryMiB;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithAcceleratorTotalMemoryMiB(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetAcceleratorTotalMemoryMiBRequestArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetAcceleratorTotalMemoryMiBRequestArgs();
        @configure(@item);
        @selfRef.AcceleratorTotalMemoryMiB = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithAcceleratorTypes(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestAcceleratorTypesItem> acceleratorTypes)
    {
        @selfRef.AcceleratorTypes = acceleratorTypes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithAcceleratorTypes(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestAcceleratorTypesItem>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestAcceleratorTypesItem>();
        @configure(@list);
        @selfRef.AcceleratorTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithAcceleratorTypes(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestAcceleratorTypesItem>> @create)
    {
        @selfRef.AcceleratorTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithAllowedInstanceTypes(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Collections.Generic.List<global::System.String> allowedInstanceTypes)
    {
        @selfRef.AllowedInstanceTypes = allowedInstanceTypes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithAllowedInstanceTypes(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AllowedInstanceTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithAllowedInstanceTypes(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AllowedInstanceTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithBareMetal(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestBareMetal bareMetal)
    {
        @selfRef.BareMetal = bareMetal;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithBareMetal(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestBareMetal> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestBareMetal>();
        @configure(@item);
        @selfRef.BareMetal = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithBaselineEbsBandwidthMbps(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetBaselineEbsBandwidthMbpsRequestArgs baselineEbsBandwidthMbps)
    {
        @selfRef.BaselineEbsBandwidthMbps = baselineEbsBandwidthMbps;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithBaselineEbsBandwidthMbps(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetBaselineEbsBandwidthMbpsRequestArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetBaselineEbsBandwidthMbpsRequestArgs();
        @configure(@item);
        @selfRef.BaselineEbsBandwidthMbps = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithBaselinePerformanceFactors(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetBaselinePerformanceFactorsRequestArgs baselinePerformanceFactors)
    {
        @selfRef.BaselinePerformanceFactors = baselinePerformanceFactors;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithBaselinePerformanceFactors(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetBaselinePerformanceFactorsRequestArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetBaselinePerformanceFactorsRequestArgs();
        @configure(@item);
        @selfRef.BaselinePerformanceFactors = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithBurstablePerformance(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestBurstablePerformance burstablePerformance)
    {
        @selfRef.BurstablePerformance = burstablePerformance;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithBurstablePerformance(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestBurstablePerformance> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestBurstablePerformance>();
        @configure(@item);
        @selfRef.BurstablePerformance = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithCpuManufacturers(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestCpuManufacturersItem> cpuManufacturers)
    {
        @selfRef.CpuManufacturers = cpuManufacturers;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithCpuManufacturers(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestCpuManufacturersItem>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestCpuManufacturersItem>();
        @configure(@list);
        @selfRef.CpuManufacturers = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithCpuManufacturers(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestCpuManufacturersItem>> @create)
    {
        @selfRef.CpuManufacturers = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithExcludedInstanceTypes(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Collections.Generic.List<global::System.String> excludedInstanceTypes)
    {
        @selfRef.ExcludedInstanceTypes = excludedInstanceTypes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithExcludedInstanceTypes(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ExcludedInstanceTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithExcludedInstanceTypes(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ExcludedInstanceTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithInstanceGenerations(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestInstanceGenerationsItem> instanceGenerations)
    {
        @selfRef.InstanceGenerations = instanceGenerations;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithInstanceGenerations(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestInstanceGenerationsItem>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestInstanceGenerationsItem>();
        @configure(@list);
        @selfRef.InstanceGenerations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithInstanceGenerations(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestInstanceGenerationsItem>> @create)
    {
        @selfRef.InstanceGenerations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithLocalStorage(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestLocalStorage localStorage)
    {
        @selfRef.LocalStorage = localStorage;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithLocalStorage(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestLocalStorage> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestLocalStorage>();
        @configure(@item);
        @selfRef.LocalStorage = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithLocalStorageTypes(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestLocalStorageTypesItem> localStorageTypes)
    {
        @selfRef.LocalStorageTypes = localStorageTypes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithLocalStorageTypes(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestLocalStorageTypesItem>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestLocalStorageTypesItem>();
        @configure(@list);
        @selfRef.LocalStorageTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithLocalStorageTypes(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ec2.SpotFleetInstanceRequirementsRequestLocalStorageTypesItem>> @create)
    {
        @selfRef.LocalStorageTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithMaxSpotPriceAsPercentageOfOptimalOnDemandPrice(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Int32 maxSpotPriceAsPercentageOfOptimalOnDemandPrice)
    {
        @selfRef.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice = maxSpotPriceAsPercentageOfOptimalOnDemandPrice;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithMemoryGiBPerVCpu(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetMemoryGiBPerVCpuRequestArgs memoryGiBPerVCpu)
    {
        @selfRef.MemoryGiBPerVCpu = memoryGiBPerVCpu;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithMemoryGiBPerVCpu(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetMemoryGiBPerVCpuRequestArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetMemoryGiBPerVCpuRequestArgs();
        @configure(@item);
        @selfRef.MemoryGiBPerVCpu = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithMemoryMiB(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetMemoryMiBRequestArgs memoryMiB)
    {
        @selfRef.MemoryMiB = memoryMiB;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithMemoryMiB(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetMemoryMiBRequestArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetMemoryMiBRequestArgs();
        @configure(@item);
        @selfRef.MemoryMiB = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithNetworkBandwidthGbps(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetNetworkBandwidthGbpsRequestArgs networkBandwidthGbps)
    {
        @selfRef.NetworkBandwidthGbps = networkBandwidthGbps;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithNetworkBandwidthGbps(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetNetworkBandwidthGbpsRequestArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetNetworkBandwidthGbpsRequestArgs();
        @configure(@item);
        @selfRef.NetworkBandwidthGbps = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithNetworkInterfaceCount(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetNetworkInterfaceCountRequestArgs networkInterfaceCount)
    {
        @selfRef.NetworkInterfaceCount = networkInterfaceCount;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithNetworkInterfaceCount(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetNetworkInterfaceCountRequestArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetNetworkInterfaceCountRequestArgs();
        @configure(@item);
        @selfRef.NetworkInterfaceCount = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithOnDemandMaxPricePercentageOverLowestPrice(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Int32 onDemandMaxPricePercentageOverLowestPrice)
    {
        @selfRef.OnDemandMaxPricePercentageOverLowestPrice = onDemandMaxPricePercentageOverLowestPrice;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithRequireHibernateSupport(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, bool requireHibernateSupport = true)
    {
        @selfRef.RequireHibernateSupport = requireHibernateSupport;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithSpotMaxPricePercentageOverLowestPrice(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Int32 spotMaxPricePercentageOverLowestPrice)
    {
        @selfRef.SpotMaxPricePercentageOverLowestPrice = spotMaxPricePercentageOverLowestPrice;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithTotalLocalStorageGb(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetTotalLocalStorageGbRequestArgs totalLocalStorageGb)
    {
        @selfRef.TotalLocalStorageGb = totalLocalStorageGb;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithTotalLocalStorageGb(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetTotalLocalStorageGbRequestArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetTotalLocalStorageGbRequestArgs();
        @configure(@item);
        @selfRef.TotalLocalStorageGb = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithVCpuCount(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetVCpuCountRangeRequestArgs vCpuCount)
    {
        @selfRef.VCpuCount = vCpuCount;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs WithVCpuCount(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetInstanceRequirementsRequestArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetVCpuCountRangeRequestArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetVCpuCountRangeRequestArgs();
        @configure(@item);
        @selfRef.VCpuCount = @item;
        return @selfRef;
    }

}
