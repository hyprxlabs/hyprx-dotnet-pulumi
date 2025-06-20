// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Workloads.Inputs;

namespace Pulumi.AzureNative.Workloads;

public static partial class DatabaseServerFullResourceNamesArgsExtensions
{
    public static global::Pulumi.AzureNative.Workloads.Inputs.DatabaseServerFullResourceNamesArgs WithAvailabilitySetName(this global::Pulumi.AzureNative.Workloads.Inputs.DatabaseServerFullResourceNamesArgs @selfRef, global::System.String availabilitySetName)
    {
        @selfRef.AvailabilitySetName = availabilitySetName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.DatabaseServerFullResourceNamesArgs WithLoadBalancer(this global::Pulumi.AzureNative.Workloads.Inputs.DatabaseServerFullResourceNamesArgs @selfRef, global::Pulumi.AzureNative.Workloads.Inputs.LoadBalancerResourceNamesArgs loadBalancer)
    {
        @selfRef.LoadBalancer = loadBalancer;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.DatabaseServerFullResourceNamesArgs WithLoadBalancer(this global::Pulumi.AzureNative.Workloads.Inputs.DatabaseServerFullResourceNamesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Workloads.Inputs.LoadBalancerResourceNamesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Workloads.Inputs.LoadBalancerResourceNamesArgs();
        @configure(@item);
        @selfRef.LoadBalancer = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.DatabaseServerFullResourceNamesArgs WithVirtualMachines(this global::Pulumi.AzureNative.Workloads.Inputs.DatabaseServerFullResourceNamesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Workloads.Inputs.VirtualMachineResourceNamesArgs> virtualMachines)
    {
        @selfRef.VirtualMachines = virtualMachines;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.DatabaseServerFullResourceNamesArgs WithVirtualMachines(this global::Pulumi.AzureNative.Workloads.Inputs.DatabaseServerFullResourceNamesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Workloads.Inputs.VirtualMachineResourceNamesArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Workloads.Inputs.VirtualMachineResourceNamesArgs>();
        @configure(@list);
        @selfRef.VirtualMachines = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.DatabaseServerFullResourceNamesArgs WithVirtualMachines(this global::Pulumi.AzureNative.Workloads.Inputs.DatabaseServerFullResourceNamesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Workloads.Inputs.VirtualMachineResourceNamesArgs>> @create)
    {
        @selfRef.VirtualMachines = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
