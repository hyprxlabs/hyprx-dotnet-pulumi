// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DatabaseFleetManager.Inputs;

namespace Pulumi.AzureNative.DatabaseFleetManager;

public static partial class FirewallRulePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FirewallRulePropertiesArgs WithEndIpAddress(this global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FirewallRulePropertiesArgs @selfRef, global::System.String endIpAddress)
    {
        @selfRef.EndIpAddress = endIpAddress;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FirewallRulePropertiesArgs WithStartIpAddress(this global::Pulumi.AzureNative.DatabaseFleetManager.Inputs.FirewallRulePropertiesArgs @selfRef, global::System.String startIpAddress)
    {
        @selfRef.StartIpAddress = startIpAddress;
        return @selfRef;
    }

}
