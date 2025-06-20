// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerService.Inputs;

namespace Pulumi.AzureNative.ContainerService;

public static partial class AgentPoolNetworkProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerService.Inputs.AgentPoolNetworkProfileArgs WithAllowedHostPorts(this global::Pulumi.AzureNative.ContainerService.Inputs.AgentPoolNetworkProfileArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.PortRangeArgs> allowedHostPorts)
    {
        @selfRef.AllowedHostPorts = allowedHostPorts;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.AgentPoolNetworkProfileArgs WithAllowedHostPorts(this global::Pulumi.AzureNative.ContainerService.Inputs.AgentPoolNetworkProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.PortRangeArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.PortRangeArgs>();
        @configure(@list);
        @selfRef.AllowedHostPorts = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.AgentPoolNetworkProfileArgs WithAllowedHostPorts(this global::Pulumi.AzureNative.ContainerService.Inputs.AgentPoolNetworkProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ContainerService.Inputs.PortRangeArgs>> @create)
    {
        @selfRef.AllowedHostPorts = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.AgentPoolNetworkProfileArgs WithApplicationSecurityGroups(this global::Pulumi.AzureNative.ContainerService.Inputs.AgentPoolNetworkProfileArgs @selfRef, global::System.Collections.Generic.List<global::System.String> applicationSecurityGroups)
    {
        @selfRef.ApplicationSecurityGroups = applicationSecurityGroups;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.AgentPoolNetworkProfileArgs WithApplicationSecurityGroups(this global::Pulumi.AzureNative.ContainerService.Inputs.AgentPoolNetworkProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ApplicationSecurityGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.AgentPoolNetworkProfileArgs WithApplicationSecurityGroups(this global::Pulumi.AzureNative.ContainerService.Inputs.AgentPoolNetworkProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ApplicationSecurityGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.AgentPoolNetworkProfileArgs WithNodePublicIPTags(this global::Pulumi.AzureNative.ContainerService.Inputs.AgentPoolNetworkProfileArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.IPTagArgs> nodePublicIPTags)
    {
        @selfRef.NodePublicIPTags = nodePublicIPTags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.AgentPoolNetworkProfileArgs WithNodePublicIPTags(this global::Pulumi.AzureNative.ContainerService.Inputs.AgentPoolNetworkProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.IPTagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.IPTagArgs>();
        @configure(@list);
        @selfRef.NodePublicIPTags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.AgentPoolNetworkProfileArgs WithNodePublicIPTags(this global::Pulumi.AzureNative.ContainerService.Inputs.AgentPoolNetworkProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ContainerService.Inputs.IPTagArgs>> @create)
    {
        @selfRef.NodePublicIPTags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
