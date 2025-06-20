// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ScVmm;

public static partial class VirtualMachineTemplateExtensions
{

    extension(VirtualMachineTemplate)
    {
        public static VirtualMachineTemplate New(string @id, global::Pulumi.AzureNative.ScVmm.VirtualMachineTemplateArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new VirtualMachineTemplate(@id, @args, @options);
        }

        public static VirtualMachineTemplate New(string @id, global::System.Action<global::Pulumi.AzureNative.ScVmm.VirtualMachineTemplateArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.ScVmm.VirtualMachineTemplateArgs @args = new();
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

            return new VirtualMachineTemplate(@id, @args, @options);
        }

    }

}
