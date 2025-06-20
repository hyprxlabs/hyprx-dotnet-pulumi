// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Migrate;

public static partial class WebAppCollectorOperationExtensions
{

    extension(WebAppCollectorOperation)
    {
        public static WebAppCollectorOperation New(string @id, global::Pulumi.AzureNative.Migrate.WebAppCollectorOperationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new WebAppCollectorOperation(@id, @args, @options);
        }

        public static WebAppCollectorOperation New(string @id, global::System.Action<global::Pulumi.AzureNative.Migrate.WebAppCollectorOperationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Migrate.WebAppCollectorOperationArgs @args = new();
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

            return new WebAppCollectorOperation(@id, @args, @options);
        }

    }

}
