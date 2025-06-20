// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Workloads;

public static partial class SapVirtualInstanceExtensions
{

    extension(SapVirtualInstance)
    {
        public static SapVirtualInstance New(string @id, global::Pulumi.AzureNative.Workloads.SapVirtualInstanceArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new SapVirtualInstance(@id, @args, @options);
        }

        public static SapVirtualInstance New(string @id, global::System.Action<global::Pulumi.AzureNative.Workloads.SapVirtualInstanceArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Workloads.SapVirtualInstanceArgs @args = new();
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

            return new SapVirtualInstance(@id, @args, @options);
        }

    }

}
