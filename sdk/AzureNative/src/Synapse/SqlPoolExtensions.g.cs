// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Synapse;

public static partial class SqlPoolExtensions
{

    extension(SqlPool)
    {
        public static SqlPool New(string @id, global::Pulumi.AzureNative.Synapse.SqlPoolArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new SqlPool(@id, @args, @options);
        }

        public static SqlPool New(string @id, global::System.Action<global::Pulumi.AzureNative.Synapse.SqlPoolArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Synapse.SqlPoolArgs @args = new();
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

            return new SqlPool(@id, @args, @options);
        }

    }

}
