// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Pinpoint;

public static partial class InAppTemplateExtensions
{

    extension(InAppTemplate)
    {
        public static InAppTemplate New(string @id, global::Pulumi.AwsNative.Pinpoint.InAppTemplateArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new InAppTemplate(@id, @args, @options);
        }

        public static InAppTemplate New(string @id, global::System.Action<global::Pulumi.AwsNative.Pinpoint.InAppTemplateArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Pinpoint.InAppTemplateArgs @args = new();
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

            return new InAppTemplate(@id, @args, @options);
        }

    }

}
