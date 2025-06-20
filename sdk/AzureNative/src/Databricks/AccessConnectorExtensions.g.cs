// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Databricks;

public static partial class AccessConnectorExtensions
{

    extension(AccessConnector)
    {
        public static AccessConnector New(string @id, global::Pulumi.AzureNative.Databricks.AccessConnectorArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new AccessConnector(@id, @args, @options);
        }

        public static AccessConnector New(string @id, global::System.Action<global::Pulumi.AzureNative.Databricks.AccessConnectorArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Databricks.AccessConnectorArgs @args = new();
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

            return new AccessConnector(@id, @args, @options);
        }

    }

}
