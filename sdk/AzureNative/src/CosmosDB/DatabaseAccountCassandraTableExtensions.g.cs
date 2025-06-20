// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.CosmosDB;

public static partial class DatabaseAccountCassandraTableExtensions
{

    extension(DatabaseAccountCassandraTable)
    {
        public static DatabaseAccountCassandraTable New(string @id, global::Pulumi.AzureNative.CosmosDB.DatabaseAccountCassandraTableArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new DatabaseAccountCassandraTable(@id, @args, @options);
        }

        public static DatabaseAccountCassandraTable New(string @id, global::System.Action<global::Pulumi.AzureNative.CosmosDB.DatabaseAccountCassandraTableArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.CosmosDB.DatabaseAccountCassandraTableArgs @args = new();
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

            return new DatabaseAccountCassandraTable(@id, @args, @options);
        }

    }

}
