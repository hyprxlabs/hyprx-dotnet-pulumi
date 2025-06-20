// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Sql;

public static partial class FirewallRuleExtensions
{

    extension(FirewallRule)
    {
        public static FirewallRule New(string @id, global::Pulumi.AzureNative.Sql.FirewallRuleArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new FirewallRule(@id, @args, @options);
        }

        public static FirewallRule New(string @id, global::System.Action<global::Pulumi.AzureNative.Sql.FirewallRuleArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Sql.FirewallRuleArgs @args = new();
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

            return new FirewallRule(@id, @args, @options);
        }

    }

}
