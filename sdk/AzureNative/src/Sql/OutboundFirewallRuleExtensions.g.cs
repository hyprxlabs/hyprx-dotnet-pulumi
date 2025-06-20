// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Sql;

public static partial class OutboundFirewallRuleExtensions
{

    extension(OutboundFirewallRule)
    {
        public static OutboundFirewallRule New(string @id, global::Pulumi.AzureNative.Sql.OutboundFirewallRuleArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new OutboundFirewallRule(@id, @args, @options);
        }

        public static OutboundFirewallRule New(string @id, global::System.Action<global::Pulumi.AzureNative.Sql.OutboundFirewallRuleArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Sql.OutboundFirewallRuleArgs @args = new();
            global::Pulumi.CustomResourceOptions? @options = null;
            if (@configureArgs is not null)
            {
                @configureArgs(@args);
            }

            if (@configureOptions is not null)
            {
                @options = new();
                @configureOptions(@options);
            }

            return new OutboundFirewallRule(@id, @args, @options);
        }

    }

}
