// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ConnectedCache;

public static partial class EnterpriseMccCustomerExtensions
{

    extension(EnterpriseMccCustomer)
    {
        public static EnterpriseMccCustomer New(string @id, global::Pulumi.AzureNative.ConnectedCache.EnterpriseMccCustomerArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new EnterpriseMccCustomer(@id, @args, @options);
        }

        public static EnterpriseMccCustomer New(string @id, global::System.Action<global::Pulumi.AzureNative.ConnectedCache.EnterpriseMccCustomerArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.ConnectedCache.EnterpriseMccCustomerArgs @args = new();
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

            return new EnterpriseMccCustomer(@id, @args, @options);
        }

    }

}
