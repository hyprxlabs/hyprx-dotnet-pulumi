// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Web;

public static partial class StaticSiteLinkedBackendForBuildExtensions
{

    extension(StaticSiteLinkedBackendForBuild)
    {
        public static StaticSiteLinkedBackendForBuild New(string @id, global::Pulumi.AzureNative.Web.StaticSiteLinkedBackendForBuildArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new StaticSiteLinkedBackendForBuild(@id, @args, @options);
        }

        public static StaticSiteLinkedBackendForBuild New(string @id, global::System.Action<global::Pulumi.AzureNative.Web.StaticSiteLinkedBackendForBuildArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Web.StaticSiteLinkedBackendForBuildArgs @args = new();
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

            return new StaticSiteLinkedBackendForBuild(@id, @args, @options);
        }

    }

}
