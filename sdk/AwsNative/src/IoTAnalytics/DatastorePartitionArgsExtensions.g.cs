// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTAnalytics.Inputs;

namespace Pulumi.AwsNative.IoTAnalytics;

public static partial class DatastorePartitionArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastorePartitionArgs WithPartition(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastorePartitionArgs @selfRef, global::Pulumi.AwsNative.IoTAnalytics.Inputs.PartitionArgs partition)
    {
        @selfRef.Partition = partition;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastorePartitionArgs WithPartition(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastorePartitionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTAnalytics.Inputs.PartitionArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTAnalytics.Inputs.PartitionArgs();
        @configure(@item);
        @selfRef.Partition = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastorePartitionArgs WithTimestampPartition(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastorePartitionArgs @selfRef, global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastoreTimestampPartitionArgs timestampPartition)
    {
        @selfRef.TimestampPartition = timestampPartition;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastorePartitionArgs WithTimestampPartition(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastorePartitionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastoreTimestampPartitionArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatastoreTimestampPartitionArgs();
        @configure(@item);
        @selfRef.TimestampPartition = @item;
        return @selfRef;
    }

}
