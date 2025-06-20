// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Kusto;

public static partial class IotHubDataConnectionExtensions
{

    extension(IotHubDataConnection)
    {
        public static IotHubDataConnection New(string @id, global::Pulumi.AzureNative.Kusto.IotHubDataConnectionArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new IotHubDataConnection(@id, @args, @options);
        }

        public static IotHubDataConnection New(string @id, global::System.Action<global::Pulumi.AzureNative.Kusto.IotHubDataConnectionArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Kusto.IotHubDataConnectionArgs @args = new();
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

            return new IotHubDataConnection(@id, @args, @options);
        }

    }

}
