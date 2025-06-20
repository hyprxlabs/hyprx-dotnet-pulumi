// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.SecurityInsights;

public static partial class BusinessApplicationAgentExtensions
{

    extension(BusinessApplicationAgent)
    {
        public static BusinessApplicationAgent New(string @id, global::Pulumi.AzureNative.SecurityInsights.BusinessApplicationAgentArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new BusinessApplicationAgent(@id, @args, @options);
        }

        public static BusinessApplicationAgent New(string @id, global::System.Action<global::Pulumi.AzureNative.SecurityInsights.BusinessApplicationAgentArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.SecurityInsights.BusinessApplicationAgentArgs @args = new();
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

            return new BusinessApplicationAgent(@id, @args, @options);
        }

    }

}
