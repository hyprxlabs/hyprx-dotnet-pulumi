// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.StandbyPool;

public static partial class StandbyVirtualMachinePoolExtensions
{

    extension(StandbyVirtualMachinePool)
    {
        public static StandbyVirtualMachinePool New(string @id, global::Pulumi.AzureNative.StandbyPool.StandbyVirtualMachinePoolArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new StandbyVirtualMachinePool(@id, @args, @options);
        }

        public static StandbyVirtualMachinePool New(string @id, global::System.Action<global::Pulumi.AzureNative.StandbyPool.StandbyVirtualMachinePoolArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.StandbyPool.StandbyVirtualMachinePoolArgs @args = new();
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

            return new StandbyVirtualMachinePool(@id, @args, @options);
        }

    }

}
