// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerService.Inputs;

namespace Pulumi.AzureNative.ContainerService;

public static partial class AgentProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerService.Inputs.AgentProfileArgs WithSubnetId(this global::Pulumi.AzureNative.ContainerService.Inputs.AgentProfileArgs @selfRef, global::System.String subnetId)
    {
        @selfRef.SubnetId = subnetId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.AgentProfileArgs WithVmSize(this global::Pulumi.AzureNative.ContainerService.Inputs.AgentProfileArgs @selfRef, global::System.String vmSize)
    {
        @selfRef.VmSize = vmSize;
        return @selfRef;
    }

}
