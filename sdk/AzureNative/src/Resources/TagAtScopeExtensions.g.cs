// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Resources;

public static partial class TagAtScopeExtensions
{

    extension(TagAtScope)
    {
        public static TagAtScope New(string @id, global::Pulumi.AzureNative.Resources.TagAtScopeArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new TagAtScope(@id, @args, @options);
        }

        public static TagAtScope New(string @id, global::System.Action<global::Pulumi.AzureNative.Resources.TagAtScopeArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Resources.TagAtScopeArgs @args = new();
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

            return new TagAtScope(@id, @args, @options);
        }

    }

}
