// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DevTestLab.Inputs;

namespace Pulumi.AzureNative.DevTestLab;

public static partial class InboundNatRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.DevTestLab.Inputs.InboundNatRuleArgs WithBackendPort(this global::Pulumi.AzureNative.DevTestLab.Inputs.InboundNatRuleArgs @selfRef, global::System.Int32 backendPort)
    {
        @selfRef.BackendPort = backendPort;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.InboundNatRuleArgs WithFrontendPort(this global::Pulumi.AzureNative.DevTestLab.Inputs.InboundNatRuleArgs @selfRef, global::System.Int32 frontendPort)
    {
        @selfRef.FrontendPort = frontendPort;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.InboundNatRuleArgs WithTransportProtocol(this global::Pulumi.AzureNative.DevTestLab.Inputs.InboundNatRuleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DevTestLab.TransportProtocol> transportProtocol)
    {
        @selfRef.TransportProtocol = transportProtocol;
        return @selfRef;
    }

}
