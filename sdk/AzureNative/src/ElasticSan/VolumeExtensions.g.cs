// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ElasticSan;

public static partial class VolumeExtensions
{

    extension(Volume)
    {
        public static Volume New(string @id, global::Pulumi.AzureNative.ElasticSan.VolumeArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Volume(@id, @args, @options);
        }

        public static Volume New(string @id, global::System.Action<global::Pulumi.AzureNative.ElasticSan.VolumeArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.ElasticSan.VolumeArgs @args = new();
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

            return new Volume(@id, @args, @options);
        }

    }

}
