// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Sql;

public static partial class FirewallRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.Sql.FirewallRuleArgs WithEndIpAddress(this global::Pulumi.AzureNative.Sql.FirewallRuleArgs @selfRef, global::System.String endIpAddress)
    {
        @selfRef.EndIpAddress = endIpAddress;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FirewallRuleArgs WithFirewallRuleName(this global::Pulumi.AzureNative.Sql.FirewallRuleArgs @selfRef, global::System.String firewallRuleName)
    {
        @selfRef.FirewallRuleName = firewallRuleName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FirewallRuleArgs WithName(this global::Pulumi.AzureNative.Sql.FirewallRuleArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FirewallRuleArgs WithResourceGroupName(this global::Pulumi.AzureNative.Sql.FirewallRuleArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FirewallRuleArgs WithServerName(this global::Pulumi.AzureNative.Sql.FirewallRuleArgs @selfRef, global::System.String serverName)
    {
        @selfRef.ServerName = serverName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.FirewallRuleArgs WithStartIpAddress(this global::Pulumi.AzureNative.Sql.FirewallRuleArgs @selfRef, global::System.String startIpAddress)
    {
        @selfRef.StartIpAddress = startIpAddress;
        return @selfRef;
    }

}
