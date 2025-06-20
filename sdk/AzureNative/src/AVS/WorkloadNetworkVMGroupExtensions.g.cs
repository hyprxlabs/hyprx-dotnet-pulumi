// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AVS;

public static partial class WorkloadNetworkVMGroupExtensions
{

    extension(WorkloadNetworkVMGroup)
    {
        public static WorkloadNetworkVMGroup New(string @id, global::Pulumi.AzureNative.AVS.WorkloadNetworkVMGroupArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new WorkloadNetworkVMGroup(@id, @args, @options);
        }

        public static WorkloadNetworkVMGroup New(string @id, global::System.Action<global::Pulumi.AzureNative.AVS.WorkloadNetworkVMGroupArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.AVS.WorkloadNetworkVMGroupArgs @args = new();
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

            return new WorkloadNetworkVMGroup(@id, @args, @options);
        }

    }

}
