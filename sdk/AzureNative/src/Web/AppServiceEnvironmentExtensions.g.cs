// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Web;

public static partial class AppServiceEnvironmentExtensions
{

    extension(AppServiceEnvironment)
    {
        public static AppServiceEnvironment New(string @id, global::Pulumi.AzureNative.Web.AppServiceEnvironmentArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new AppServiceEnvironment(@id, @args, @options);
        }

        public static AppServiceEnvironment New(string @id, global::System.Action<global::Pulumi.AzureNative.Web.AppServiceEnvironmentArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Web.AppServiceEnvironmentArgs @args = new();
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

            return new AppServiceEnvironment(@id, @args, @options);
        }

    }

}
