// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AgriculturePlatform;

public static partial class AgriServiceExtensions
{

    extension(AgriService)
    {
        public static AgriService New(string @id, global::Pulumi.AzureNative.AgriculturePlatform.AgriServiceArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new AgriService(@id, @args, @options);
        }

        public static AgriService New(string @id, global::System.Action<global::Pulumi.AzureNative.AgriculturePlatform.AgriServiceArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.AgriculturePlatform.AgriServiceArgs @args = new();
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

            return new AgriService(@id, @args, @options);
        }

    }

}
