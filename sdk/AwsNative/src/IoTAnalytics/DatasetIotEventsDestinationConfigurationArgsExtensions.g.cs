// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTAnalytics.Inputs;

namespace Pulumi.AwsNative.IoTAnalytics;

public static partial class DatasetIotEventsDestinationConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetIotEventsDestinationConfigurationArgs WithInputName(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetIotEventsDestinationConfigurationArgs @selfRef, global::System.String inputName)
    {
        @selfRef.InputName = inputName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetIotEventsDestinationConfigurationArgs WithRoleArn(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetIotEventsDestinationConfigurationArgs @selfRef, global::System.String roleArn)
    {
        @selfRef.RoleArn = roleArn;
        return @selfRef;
    }

}
