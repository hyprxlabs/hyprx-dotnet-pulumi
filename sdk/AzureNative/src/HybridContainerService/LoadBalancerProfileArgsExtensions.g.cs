// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HybridContainerService.Inputs;

namespace Pulumi.AzureNative.HybridContainerService;

public static partial class LoadBalancerProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithAvailabilityZones(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::System.Collections.Generic.List<global::System.String> availabilityZones)
    {
        @selfRef.AvailabilityZones = availabilityZones;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithAvailabilityZones(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AvailabilityZones = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithAvailabilityZones(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AvailabilityZones = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithCloudProviderProfile(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::Pulumi.AzureNative.HybridContainerService.Inputs.CloudProviderProfileArgs cloudProviderProfile)
    {
        @selfRef.CloudProviderProfile = cloudProviderProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithCloudProviderProfile(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HybridContainerService.Inputs.CloudProviderProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HybridContainerService.Inputs.CloudProviderProfileArgs();
        @configure(@item);
        @selfRef.CloudProviderProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithCount(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::System.Int32 count)
    {
        @selfRef.Count = count;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithLinuxProfile(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::Pulumi.AzureNative.HybridContainerService.Inputs.LinuxProfilePropertiesArgs linuxProfile)
    {
        @selfRef.LinuxProfile = linuxProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithLinuxProfile(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HybridContainerService.Inputs.LinuxProfilePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HybridContainerService.Inputs.LinuxProfilePropertiesArgs();
        @configure(@item);
        @selfRef.LinuxProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithMaxCount(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::System.Int32 maxCount)
    {
        @selfRef.MaxCount = maxCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithMaxPods(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::System.Int32 maxPods)
    {
        @selfRef.MaxPods = maxPods;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithMinCount(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::System.Int32 minCount)
    {
        @selfRef.MinCount = minCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithMode(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.HybridContainerService.Mode> mode)
    {
        @selfRef.Mode = mode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithName(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithNodeImageVersion(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::System.String nodeImageVersion)
    {
        @selfRef.NodeImageVersion = nodeImageVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithNodeLabels(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> nodeLabels)
    {
        @selfRef.NodeLabels = nodeLabels;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithNodeLabels(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.NodeLabels = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithNodeLabels(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.NodeLabels = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithNodeTaints(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::System.Collections.Generic.List<global::System.String> nodeTaints)
    {
        @selfRef.NodeTaints = nodeTaints;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithNodeTaints(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.NodeTaints = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithNodeTaints(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.NodeTaints = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithOsType(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.HybridContainerService.OsType> osType)
    {
        @selfRef.OsType = osType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs WithVmSize(this global::Pulumi.AzureNative.HybridContainerService.Inputs.LoadBalancerProfileArgs @selfRef, global::System.String vmSize)
    {
        @selfRef.VmSize = vmSize;
        return @selfRef;
    }

}
