// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.VirtualMachineImages;

public static partial class TriggerExtensions
{

    extension(Trigger)
    {
        public static Trigger New(string @id, global::Pulumi.AzureNative.VirtualMachineImages.TriggerArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Trigger(@id, @args, @options);
        }

        public static Trigger New(string @id, global::System.Action<global::Pulumi.AzureNative.VirtualMachineImages.TriggerArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.VirtualMachineImages.TriggerArgs @args = new();
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

            return new Trigger(@id, @args, @options);
        }

    }

}
