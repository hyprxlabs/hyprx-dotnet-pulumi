// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ApiManagement;

public static partial class ApiReleaseExtensions
{

    extension(ApiRelease)
    {
        public static ApiRelease New(string @id, global::Pulumi.AzureNative.ApiManagement.ApiReleaseArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ApiRelease(@id, @args, @options);
        }

        public static ApiRelease New(string @id, global::System.Action<global::Pulumi.AzureNative.ApiManagement.ApiReleaseArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.ApiManagement.ApiReleaseArgs @args = new();
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

            return new ApiRelease(@id, @args, @options);
        }

    }

}
