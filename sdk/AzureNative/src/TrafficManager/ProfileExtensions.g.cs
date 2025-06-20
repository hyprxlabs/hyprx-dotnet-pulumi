// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.TrafficManager;

public static partial class ProfileExtensions
{

    extension(Profile)
    {
        public static Profile New(string @id, global::Pulumi.AzureNative.TrafficManager.ProfileArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Profile(@id, @args, @options);
        }

        public static Profile New(string @id, global::System.Action<global::Pulumi.AzureNative.TrafficManager.ProfileArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.TrafficManager.ProfileArgs @args = new();
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

            return new Profile(@id, @args, @options);
        }

    }

}
