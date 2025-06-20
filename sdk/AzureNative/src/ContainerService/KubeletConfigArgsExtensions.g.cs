// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerService.Inputs;

namespace Pulumi.AzureNative.ContainerService;

public static partial class KubeletConfigArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs WithAllowedUnsafeSysctls(this global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs @selfRef, global::System.Collections.Generic.List<global::System.String> allowedUnsafeSysctls)
    {
        @selfRef.AllowedUnsafeSysctls = allowedUnsafeSysctls;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs WithAllowedUnsafeSysctls(this global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AllowedUnsafeSysctls = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs WithAllowedUnsafeSysctls(this global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AllowedUnsafeSysctls = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs WithContainerLogMaxFiles(this global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs @selfRef, global::System.Int32 containerLogMaxFiles)
    {
        @selfRef.ContainerLogMaxFiles = containerLogMaxFiles;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs WithContainerLogMaxSizeMB(this global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs @selfRef, global::System.Int32 containerLogMaxSizeMB)
    {
        @selfRef.ContainerLogMaxSizeMB = containerLogMaxSizeMB;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs WithCpuCfsQuota(this global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs @selfRef, bool cpuCfsQuota = true)
    {
        @selfRef.CpuCfsQuota = cpuCfsQuota;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs WithCpuCfsQuotaPeriod(this global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs @selfRef, global::System.String cpuCfsQuotaPeriod)
    {
        @selfRef.CpuCfsQuotaPeriod = cpuCfsQuotaPeriod;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs WithCpuManagerPolicy(this global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs @selfRef, global::System.String cpuManagerPolicy)
    {
        @selfRef.CpuManagerPolicy = cpuManagerPolicy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs WithFailSwapOn(this global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs @selfRef, bool failSwapOn = true)
    {
        @selfRef.FailSwapOn = failSwapOn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs WithImageGcHighThreshold(this global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs @selfRef, global::System.Int32 imageGcHighThreshold)
    {
        @selfRef.ImageGcHighThreshold = imageGcHighThreshold;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs WithImageGcLowThreshold(this global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs @selfRef, global::System.Int32 imageGcLowThreshold)
    {
        @selfRef.ImageGcLowThreshold = imageGcLowThreshold;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs WithPodMaxPids(this global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs @selfRef, global::System.Int32 podMaxPids)
    {
        @selfRef.PodMaxPids = podMaxPids;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs WithTopologyManagerPolicy(this global::Pulumi.AzureNative.ContainerService.Inputs.KubeletConfigArgs @selfRef, global::System.String topologyManagerPolicy)
    {
        @selfRef.TopologyManagerPolicy = topologyManagerPolicy;
        return @selfRef;
    }

}
