// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class FirewallPolicyRuleConditionApplicationProtocolArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.FirewallPolicyRuleConditionApplicationProtocolArgs WithPort(this global::Pulumi.AzureNative.Network.Inputs.FirewallPolicyRuleConditionApplicationProtocolArgs @selfRef, global::System.Int32 port)
    {
        @selfRef.Port = port;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.FirewallPolicyRuleConditionApplicationProtocolArgs WithProtocolType(this global::Pulumi.AzureNative.Network.Inputs.FirewallPolicyRuleConditionApplicationProtocolArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.FirewallPolicyRuleConditionApplicationProtocolType> protocolType)
    {
        @selfRef.ProtocolType = protocolType;
        return @selfRef;
    }

}
