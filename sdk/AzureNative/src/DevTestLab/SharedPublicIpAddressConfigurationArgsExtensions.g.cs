// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DevTestLab.Inputs;

namespace Pulumi.AzureNative.DevTestLab;

public static partial class SharedPublicIpAddressConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.DevTestLab.Inputs.SharedPublicIpAddressConfigurationArgs WithInboundNatRules(this global::Pulumi.AzureNative.DevTestLab.Inputs.SharedPublicIpAddressConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DevTestLab.Inputs.InboundNatRuleArgs> inboundNatRules)
    {
        @selfRef.InboundNatRules = inboundNatRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.SharedPublicIpAddressConfigurationArgs WithInboundNatRules(this global::Pulumi.AzureNative.DevTestLab.Inputs.SharedPublicIpAddressConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DevTestLab.Inputs.InboundNatRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DevTestLab.Inputs.InboundNatRuleArgs>();
        @configure(@list);
        @selfRef.InboundNatRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.SharedPublicIpAddressConfigurationArgs WithInboundNatRules(this global::Pulumi.AzureNative.DevTestLab.Inputs.SharedPublicIpAddressConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DevTestLab.Inputs.InboundNatRuleArgs>> @create)
    {
        @selfRef.InboundNatRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
