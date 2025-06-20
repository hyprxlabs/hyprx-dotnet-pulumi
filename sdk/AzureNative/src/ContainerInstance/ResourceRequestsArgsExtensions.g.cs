// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerInstance.Inputs;

namespace Pulumi.AzureNative.ContainerInstance;

public static partial class ResourceRequestsArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerInstance.Inputs.ResourceRequestsArgs WithCpu(this global::Pulumi.AzureNative.ContainerInstance.Inputs.ResourceRequestsArgs @selfRef, global::System.Double cpu)
    {
        @selfRef.Cpu = cpu;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.Inputs.ResourceRequestsArgs WithGpu(this global::Pulumi.AzureNative.ContainerInstance.Inputs.ResourceRequestsArgs @selfRef, global::Pulumi.AzureNative.ContainerInstance.Inputs.GpuResourceArgs gpu)
    {
        @selfRef.Gpu = gpu;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.Inputs.ResourceRequestsArgs WithGpu(this global::Pulumi.AzureNative.ContainerInstance.Inputs.ResourceRequestsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ContainerInstance.Inputs.GpuResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ContainerInstance.Inputs.GpuResourceArgs();
        @configure(@item);
        @selfRef.Gpu = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.Inputs.ResourceRequestsArgs WithMemoryInGB(this global::Pulumi.AzureNative.ContainerInstance.Inputs.ResourceRequestsArgs @selfRef, global::System.Double memoryInGB)
    {
        @selfRef.MemoryInGB = memoryInGB;
        return @selfRef;
    }

}
