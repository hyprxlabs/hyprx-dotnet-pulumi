// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DBforPostgreSQL;

public static partial class ServerGroupFirewallRuleExtensions
{

    extension(ServerGroupFirewallRule)
    {
        public static ServerGroupFirewallRule New(string @id, global::Pulumi.AzureNative.DBforPostgreSQL.ServerGroupFirewallRuleArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ServerGroupFirewallRule(@id, @args, @options);
        }

        public static ServerGroupFirewallRule New(string @id, global::System.Action<global::Pulumi.AzureNative.DBforPostgreSQL.ServerGroupFirewallRuleArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.DBforPostgreSQL.ServerGroupFirewallRuleArgs @args = new();
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

            return new ServerGroupFirewallRule(@id, @args, @options);
        }

    }

}
