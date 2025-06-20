// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.EventGrid;

public static partial class ClientGroupExtensions
{

    extension(ClientGroup)
    {
        public static ClientGroup New(string @id, global::Pulumi.AzureNative.EventGrid.ClientGroupArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ClientGroup(@id, @args, @options);
        }

        public static ClientGroup New(string @id, global::System.Action<global::Pulumi.AzureNative.EventGrid.ClientGroupArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.EventGrid.ClientGroupArgs @args = new();
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

            return new ClientGroup(@id, @args, @options);
        }

    }

}
