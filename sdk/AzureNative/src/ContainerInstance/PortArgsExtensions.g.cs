// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerInstance.Inputs;

namespace Pulumi.AzureNative.ContainerInstance;

public static partial class PortArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerInstance.Inputs.PortArgs WithPort(this global::Pulumi.AzureNative.ContainerInstance.Inputs.PortArgs @selfRef, global::System.Int32 port)
    {
        @selfRef.Port = port;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerInstance.Inputs.PortArgs WithProtocol(this global::Pulumi.AzureNative.ContainerInstance.Inputs.PortArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ContainerInstance.ContainerGroupNetworkProtocol> protocol)
    {
        @selfRef.Protocol = protocol;
        return @selfRef;
    }

}
