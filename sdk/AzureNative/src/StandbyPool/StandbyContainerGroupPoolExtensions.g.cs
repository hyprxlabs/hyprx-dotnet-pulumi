// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.StandbyPool;

public static partial class StandbyContainerGroupPoolExtensions
{

    extension(StandbyContainerGroupPool)
    {
        public static StandbyContainerGroupPool New(string @id, global::Pulumi.AzureNative.StandbyPool.StandbyContainerGroupPoolArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new StandbyContainerGroupPool(@id, @args, @options);
        }

        public static StandbyContainerGroupPool New(string @id, global::System.Action<global::Pulumi.AzureNative.StandbyPool.StandbyContainerGroupPoolArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.StandbyPool.StandbyContainerGroupPoolArgs @args = new();
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

            return new StandbyContainerGroupPool(@id, @args, @options);
        }

    }

}
