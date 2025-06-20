// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DevTestLab;

public static partial class VirtualMachineExtensions
{

    extension(VirtualMachine)
    {
        public static VirtualMachine New(string @id, global::Pulumi.AzureNative.DevTestLab.VirtualMachineArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new VirtualMachine(@id, @args, @options);
        }

        public static VirtualMachine New(string @id, global::System.Action<global::Pulumi.AzureNative.DevTestLab.VirtualMachineArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.DevTestLab.VirtualMachineArgs @args = new();
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

            return new VirtualMachine(@id, @args, @options);
        }

    }

}
