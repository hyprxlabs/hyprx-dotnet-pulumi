// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Cloudngfw;

public static partial class PrefixListGlobalRulestackExtensions
{

    extension(PrefixListGlobalRulestack)
    {
        public static PrefixListGlobalRulestack New(string @id, global::Pulumi.AzureNative.Cloudngfw.PrefixListGlobalRulestackArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new PrefixListGlobalRulestack(@id, @args, @options);
        }

        public static PrefixListGlobalRulestack New(string @id, global::System.Action<global::Pulumi.AzureNative.Cloudngfw.PrefixListGlobalRulestackArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Cloudngfw.PrefixListGlobalRulestackArgs @args = new();
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

            return new PrefixListGlobalRulestack(@id, @args, @options);
        }

    }

}
