// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Compute;

public static partial class DiskExtensions
{

    extension(Disk)
    {
        public static Disk New(string @id, global::Pulumi.AzureNative.Compute.DiskArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Disk(@id, @args, @options);
        }

        public static Disk New(string @id, global::System.Action<global::Pulumi.AzureNative.Compute.DiskArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Compute.DiskArgs @args = new();
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

            return new Disk(@id, @args, @options);
        }

    }

}
