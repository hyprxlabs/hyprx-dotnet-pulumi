// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Panorama;

public static partial class ApplicationInstanceExtensions
{

    extension(ApplicationInstance)
    {
        public static ApplicationInstance New(string @id, global::Pulumi.AwsNative.Panorama.ApplicationInstanceArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ApplicationInstance(@id, @args, @options);
        }

        public static ApplicationInstance New(string @id, global::System.Action<global::Pulumi.AwsNative.Panorama.ApplicationInstanceArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Panorama.ApplicationInstanceArgs @args = new();
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

            return new ApplicationInstance(@id, @args, @options);
        }

    }

}
