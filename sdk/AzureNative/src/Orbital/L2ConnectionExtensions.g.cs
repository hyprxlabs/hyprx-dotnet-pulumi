// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Orbital;

public static partial class L2ConnectionExtensions
{

    extension(L2Connection)
    {
        public static L2Connection New(string @id, global::Pulumi.AzureNative.Orbital.L2ConnectionArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new L2Connection(@id, @args, @options);
        }

        public static L2Connection New(string @id, global::System.Action<global::Pulumi.AzureNative.Orbital.L2ConnectionArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Orbital.L2ConnectionArgs @args = new();
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

            return new L2Connection(@id, @args, @options);
        }

    }

}
