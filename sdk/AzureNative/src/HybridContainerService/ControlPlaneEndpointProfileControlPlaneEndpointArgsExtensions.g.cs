// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HybridContainerService.Inputs;

namespace Pulumi.AzureNative.HybridContainerService;

public static partial class ControlPlaneEndpointProfileControlPlaneEndpointArgsExtensions
{
    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ControlPlaneEndpointProfileControlPlaneEndpointArgs WithHostIP(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ControlPlaneEndpointProfileControlPlaneEndpointArgs @selfRef, global::System.String hostIP)
    {
        @selfRef.HostIP = hostIP;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ControlPlaneEndpointProfileControlPlaneEndpointArgs WithPort(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ControlPlaneEndpointProfileControlPlaneEndpointArgs @selfRef, global::System.String port)
    {
        @selfRef.Port = port;
        return @selfRef;
    }

}
