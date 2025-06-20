// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DataReplication;

public static partial class FabricExtensions
{

    extension(Fabric)
    {
        public static Fabric New(string @id, global::Pulumi.AzureNative.DataReplication.FabricArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Fabric(@id, @args, @options);
        }

        public static Fabric New(string @id, global::System.Action<global::Pulumi.AzureNative.DataReplication.FabricArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.DataReplication.FabricArgs @args = new();
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

            return new Fabric(@id, @args, @options);
        }

    }

}
