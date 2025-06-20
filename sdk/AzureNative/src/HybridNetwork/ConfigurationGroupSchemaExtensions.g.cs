// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.HybridNetwork;

public static partial class ConfigurationGroupSchemaExtensions
{

    extension(ConfigurationGroupSchema)
    {
        public static ConfigurationGroupSchema New(string @id, global::Pulumi.AzureNative.HybridNetwork.ConfigurationGroupSchemaArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ConfigurationGroupSchema(@id, @args, @options);
        }

        public static ConfigurationGroupSchema New(string @id, global::System.Action<global::Pulumi.AzureNative.HybridNetwork.ConfigurationGroupSchemaArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.HybridNetwork.ConfigurationGroupSchemaArgs @args = new();
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

            return new ConfigurationGroupSchema(@id, @args, @options);
        }

    }

}
