// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DBforMySQL;

public static partial class SingleServerServerAdministratorExtensions
{

    extension(SingleServerServerAdministrator)
    {
        public static SingleServerServerAdministrator New(string @id, global::Pulumi.AzureNative.DBforMySQL.SingleServerServerAdministratorArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new SingleServerServerAdministrator(@id, @args, @options);
        }

        public static SingleServerServerAdministrator New(string @id, global::System.Action<global::Pulumi.AzureNative.DBforMySQL.SingleServerServerAdministratorArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.DBforMySQL.SingleServerServerAdministratorArgs @args = new();
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

            return new SingleServerServerAdministrator(@id, @args, @options);
        }

    }

}
