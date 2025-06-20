// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.NetworkCloud;

public static partial class L2NetworkExtensions
{

    extension(L2Network)
    {
        public static L2Network New(string @id, global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new L2Network(@id, @args, @options);
        }

        public static L2Network New(string @id, global::System.Action<global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.NetworkCloud.L2NetworkArgs @args = new();
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

            return new L2Network(@id, @args, @options);
        }

    }

}
