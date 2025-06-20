// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTAnalytics.Inputs;

namespace Pulumi.AwsNative.IoTAnalytics;

public static partial class DatastorePartitionsArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastorePartitionsArgs WithPartitions(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastorePartitionsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastorePartitionArgs> partitions)
    {
        @selfRef.Partitions = partitions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastorePartitionsArgs WithPartitions(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastorePartitionsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastorePartitionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastorePartitionArgs>();
        @configure(@list);
        @selfRef.Partitions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastorePartitionsArgs WithPartitions(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastorePartitionsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastorePartitionArgs>> @create)
    {
        @selfRef.Partitions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
