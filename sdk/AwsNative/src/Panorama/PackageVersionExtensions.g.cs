// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Panorama;

public static partial class PackageVersionExtensions
{

    extension(PackageVersion)
    {
        public static PackageVersion New(string @id, global::Pulumi.AwsNative.Panorama.PackageVersionArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new PackageVersion(@id, @args, @options);
        }

        public static PackageVersion New(string @id, global::System.Action<global::Pulumi.AwsNative.Panorama.PackageVersionArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Panorama.PackageVersionArgs @args = new();
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

            return new PackageVersion(@id, @args, @options);
        }

    }

}
