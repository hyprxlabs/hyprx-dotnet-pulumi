// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Resources;

public static partial class TemplateSpecExtensions
{

    extension(TemplateSpec)
    {
        public static TemplateSpec New(string @id, global::Pulumi.AzureNative.Resources.TemplateSpecArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new TemplateSpec(@id, @args, @options);
        }

        public static TemplateSpec New(string @id, global::System.Action<global::Pulumi.AzureNative.Resources.TemplateSpecArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Resources.TemplateSpecArgs @args = new();
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

            return new TemplateSpec(@id, @args, @options);
        }

    }

}
