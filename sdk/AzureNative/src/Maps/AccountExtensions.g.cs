// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Maps;

public static partial class AccountExtensions
{

    extension(Account)
    {
        public static Account New(string @id, global::Pulumi.AzureNative.Maps.AccountArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Account(@id, @args, @options);
        }

        public static Account New(string @id, global::System.Action<global::Pulumi.AzureNative.Maps.AccountArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Maps.AccountArgs @args = new();
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

            return new Account(@id, @args, @options);
        }

    }

}
