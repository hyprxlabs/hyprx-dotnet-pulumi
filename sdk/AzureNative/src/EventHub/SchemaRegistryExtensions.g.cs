// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.EventHub;

public static partial class SchemaRegistryExtensions
{

    extension(SchemaRegistry)
    {
        public static SchemaRegistry New(string @id, global::Pulumi.AzureNative.EventHub.SchemaRegistryArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new SchemaRegistry(@id, @args, @options);
        }

        public static SchemaRegistry New(string @id, global::System.Action<global::Pulumi.AzureNative.EventHub.SchemaRegistryArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.EventHub.SchemaRegistryArgs @args = new();
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

            return new SchemaRegistry(@id, @args, @options);
        }

    }

}
