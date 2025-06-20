// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Portal;

public static partial class ConsoleWithLocationExtensions
{

    extension(ConsoleWithLocation)
    {
        public static ConsoleWithLocation New(string @id, global::Pulumi.AzureNative.Portal.ConsoleWithLocationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ConsoleWithLocation(@id, @args, @options);
        }

        public static ConsoleWithLocation New(string @id, global::System.Action<global::Pulumi.AzureNative.Portal.ConsoleWithLocationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Portal.ConsoleWithLocationArgs @args = new();
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

            return new ConsoleWithLocation(@id, @args, @options);
        }

    }

}
