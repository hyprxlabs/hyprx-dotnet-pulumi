// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Network;

public static partial class FirewallPolicyExtensions
{

    extension(FirewallPolicy)
    {
        public static FirewallPolicy New(string @id, global::Pulumi.AzureNative.Network.FirewallPolicyArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new FirewallPolicy(@id, @args, @options);
        }

        public static FirewallPolicy New(string @id, global::System.Action<global::Pulumi.AzureNative.Network.FirewallPolicyArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Network.FirewallPolicyArgs @args = new();
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

            return new FirewallPolicy(@id, @args, @options);
        }

    }

}
