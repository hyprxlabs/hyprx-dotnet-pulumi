// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerService.Inputs;

namespace Pulumi.AzureNative.ContainerService;

public static partial class ResourceQuotaArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerService.Inputs.ResourceQuotaArgs WithCpuLimit(this global::Pulumi.AzureNative.ContainerService.Inputs.ResourceQuotaArgs @selfRef, global::System.String cpuLimit)
    {
        @selfRef.CpuLimit = cpuLimit;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ResourceQuotaArgs WithCpuRequest(this global::Pulumi.AzureNative.ContainerService.Inputs.ResourceQuotaArgs @selfRef, global::System.String cpuRequest)
    {
        @selfRef.CpuRequest = cpuRequest;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ResourceQuotaArgs WithMemoryLimit(this global::Pulumi.AzureNative.ContainerService.Inputs.ResourceQuotaArgs @selfRef, global::System.String memoryLimit)
    {
        @selfRef.MemoryLimit = memoryLimit;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ResourceQuotaArgs WithMemoryRequest(this global::Pulumi.AzureNative.ContainerService.Inputs.ResourceQuotaArgs @selfRef, global::System.String memoryRequest)
    {
        @selfRef.MemoryRequest = memoryRequest;
        return @selfRef;
    }

}
