// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Timestream.Inputs;

namespace Pulumi.AwsNative.Timestream;

public static partial class ScheduledQueryTargetConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Timestream.Inputs.ScheduledQueryTargetConfigurationArgs WithTimestreamConfiguration(this global::Pulumi.AwsNative.Timestream.Inputs.ScheduledQueryTargetConfigurationArgs @selfRef, global::Pulumi.AwsNative.Timestream.Inputs.ScheduledQueryTimestreamConfigurationArgs timestreamConfiguration)
    {
        @selfRef.TimestreamConfiguration = timestreamConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Timestream.Inputs.ScheduledQueryTargetConfigurationArgs WithTimestreamConfiguration(this global::Pulumi.AwsNative.Timestream.Inputs.ScheduledQueryTargetConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Timestream.Inputs.ScheduledQueryTimestreamConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Timestream.Inputs.ScheduledQueryTimestreamConfigurationArgs();
        @configure(@item);
        @selfRef.TimestreamConfiguration = @item;
        return @selfRef;
    }

}
