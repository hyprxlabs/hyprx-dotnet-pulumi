// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.SecurityInsights;

public static partial class FusionAlertRuleExtensions
{

    extension(FusionAlertRule)
    {
        public static FusionAlertRule New(string @id, global::Pulumi.AzureNative.SecurityInsights.FusionAlertRuleArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new FusionAlertRule(@id, @args, @options);
        }

        public static FusionAlertRule New(string @id, global::System.Action<global::Pulumi.AzureNative.SecurityInsights.FusionAlertRuleArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.SecurityInsights.FusionAlertRuleArgs @args = new();
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

            return new FusionAlertRule(@id, @args, @options);
        }

    }

}
