// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ApplicationInsights;

public static partial class WebTestExtensions
{

    extension(WebTest)
    {
        public static WebTest New(string @id, global::Pulumi.AzureNative.ApplicationInsights.WebTestArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new WebTest(@id, @args, @options);
        }

        public static WebTest New(string @id, global::System.Action<global::Pulumi.AzureNative.ApplicationInsights.WebTestArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.ApplicationInsights.WebTestArgs @args = new();
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

            return new WebTest(@id, @args, @options);
        }

    }

}
