// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ApplicationInsights;

public static partial class ComponentCurrentBillingFeatureExtensions
{

    extension(ComponentCurrentBillingFeature)
    {
        public static ComponentCurrentBillingFeature New(string @id, global::Pulumi.AzureNative.ApplicationInsights.ComponentCurrentBillingFeatureArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ComponentCurrentBillingFeature(@id, @args, @options);
        }

        public static ComponentCurrentBillingFeature New(string @id, global::System.Action<global::Pulumi.AzureNative.ApplicationInsights.ComponentCurrentBillingFeatureArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.ApplicationInsights.ComponentCurrentBillingFeatureArgs @args = new();
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

            return new ComponentCurrentBillingFeature(@id, @args, @options);
        }

    }

}
