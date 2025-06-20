// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Oam;

public static partial class LinkExtensions
{

    extension(Link)
    {
        public static Link New(string @id, global::Pulumi.AwsNative.Oam.LinkArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Link(@id, @args, @options);
        }

        public static Link New(string @id, global::System.Action<global::Pulumi.AwsNative.Oam.LinkArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Oam.LinkArgs @args = new();
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

            return new Link(@id, @args, @options);
        }

    }

}
