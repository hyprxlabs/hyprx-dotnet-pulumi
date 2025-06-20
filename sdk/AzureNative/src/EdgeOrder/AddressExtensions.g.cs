// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.EdgeOrder;

public static partial class AddressExtensions
{

    extension(Address)
    {
        public static Address New(string @id, global::Pulumi.AzureNative.EdgeOrder.AddressArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Address(@id, @args, @options);
        }

        public static Address New(string @id, global::System.Action<global::Pulumi.AzureNative.EdgeOrder.AddressArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.EdgeOrder.AddressArgs @args = new();
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

            return new Address(@id, @args, @options);
        }

    }

}
