// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.PolicyInsights;

public static partial class RemediationAtResourceGroupExtensions
{

    extension(RemediationAtResourceGroup)
    {
        public static RemediationAtResourceGroup New(string @id, global::Pulumi.AzureNative.PolicyInsights.RemediationAtResourceGroupArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new RemediationAtResourceGroup(@id, @args, @options);
        }

        public static RemediationAtResourceGroup New(string @id, global::System.Action<global::Pulumi.AzureNative.PolicyInsights.RemediationAtResourceGroupArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.PolicyInsights.RemediationAtResourceGroupArgs @args = new();
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

            return new RemediationAtResourceGroup(@id, @args, @options);
        }

    }

}
