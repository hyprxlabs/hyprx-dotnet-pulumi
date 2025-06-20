// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AVS;

public static partial class WorkloadNetworkSegmentExtensions
{

    extension(WorkloadNetworkSegment)
    {
        public static WorkloadNetworkSegment New(string @id, global::Pulumi.AzureNative.AVS.WorkloadNetworkSegmentArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new WorkloadNetworkSegment(@id, @args, @options);
        }

        public static WorkloadNetworkSegment New(string @id, global::System.Action<global::Pulumi.AzureNative.AVS.WorkloadNetworkSegmentArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.AVS.WorkloadNetworkSegmentArgs @args = new();
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

            return new WorkloadNetworkSegment(@id, @args, @options);
        }

    }

}
