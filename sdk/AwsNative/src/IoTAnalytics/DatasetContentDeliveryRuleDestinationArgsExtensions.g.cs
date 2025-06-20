// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTAnalytics.Inputs;

namespace Pulumi.AwsNative.IoTAnalytics;

public static partial class DatasetContentDeliveryRuleDestinationArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetContentDeliveryRuleDestinationArgs WithIotEventsDestinationConfiguration(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetContentDeliveryRuleDestinationArgs @selfRef, global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetIotEventsDestinationConfigurationArgs iotEventsDestinationConfiguration)
    {
        @selfRef.IotEventsDestinationConfiguration = iotEventsDestinationConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetContentDeliveryRuleDestinationArgs WithIotEventsDestinationConfiguration(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetContentDeliveryRuleDestinationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetIotEventsDestinationConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetIotEventsDestinationConfigurationArgs();
        @configure(@item);
        @selfRef.IotEventsDestinationConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetContentDeliveryRuleDestinationArgs WithS3DestinationConfiguration(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetContentDeliveryRuleDestinationArgs @selfRef, global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetS3DestinationConfigurationArgs s3DestinationConfiguration)
    {
        @selfRef.S3DestinationConfiguration = s3DestinationConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetContentDeliveryRuleDestinationArgs WithS3DestinationConfiguration(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetContentDeliveryRuleDestinationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetS3DestinationConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetS3DestinationConfigurationArgs();
        @configure(@item);
        @selfRef.S3DestinationConfiguration = @item;
        return @selfRef;
    }

}
