// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class BastionHostPropertiesFormatNetworkAclsArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.BastionHostPropertiesFormatNetworkAclsArgs WithIpRules(this global::Pulumi.AzureNative.Network.Inputs.BastionHostPropertiesFormatNetworkAclsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.IPRuleArgs> ipRules)
    {
        @selfRef.IpRules = ipRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.BastionHostPropertiesFormatNetworkAclsArgs WithIpRules(this global::Pulumi.AzureNative.Network.Inputs.BastionHostPropertiesFormatNetworkAclsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.IPRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.IPRuleArgs>();
        @configure(@list);
        @selfRef.IpRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.BastionHostPropertiesFormatNetworkAclsArgs WithIpRules(this global::Pulumi.AzureNative.Network.Inputs.BastionHostPropertiesFormatNetworkAclsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.IPRuleArgs>> @create)
    {
        @selfRef.IpRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
