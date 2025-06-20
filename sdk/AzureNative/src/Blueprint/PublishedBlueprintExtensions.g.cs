// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Blueprint;

public static partial class PublishedBlueprintExtensions
{

    extension(PublishedBlueprint)
    {
        public static PublishedBlueprint New(string @id, global::Pulumi.AzureNative.Blueprint.PublishedBlueprintArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new PublishedBlueprint(@id, @args, @options);
        }

        public static PublishedBlueprint New(string @id, global::System.Action<global::Pulumi.AzureNative.Blueprint.PublishedBlueprintArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Blueprint.PublishedBlueprintArgs @args = new();
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

            return new PublishedBlueprint(@id, @args, @options);
        }

    }

}
