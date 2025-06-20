// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.TestBase;

public static partial class CustomImageExtensions
{

    extension(CustomImage)
    {
        public static CustomImage New(string @id, global::Pulumi.AzureNative.TestBase.CustomImageArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new CustomImage(@id, @args, @options);
        }

        public static CustomImage New(string @id, global::System.Action<global::Pulumi.AzureNative.TestBase.CustomImageArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.TestBase.CustomImageArgs @args = new();
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

            return new CustomImage(@id, @args, @options);
        }

    }

}
