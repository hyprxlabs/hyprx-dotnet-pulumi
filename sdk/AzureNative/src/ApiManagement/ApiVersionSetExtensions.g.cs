// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ApiManagement;

public static partial class ApiVersionSetExtensions
{

    extension(ApiVersionSet)
    {
        public static ApiVersionSet New(string @id, global::Pulumi.AzureNative.ApiManagement.ApiVersionSetArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ApiVersionSet(@id, @args, @options);
        }

        public static ApiVersionSet New(string @id, global::System.Action<global::Pulumi.AzureNative.ApiManagement.ApiVersionSetArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.ApiManagement.ApiVersionSetArgs @args = new();
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

            return new ApiVersionSet(@id, @args, @options);
        }

    }

}
