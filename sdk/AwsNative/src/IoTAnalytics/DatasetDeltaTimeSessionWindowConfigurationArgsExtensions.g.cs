// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTAnalytics.Inputs;

namespace Pulumi.AwsNative.IoTAnalytics;

public static partial class DatasetDeltaTimeSessionWindowConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetDeltaTimeSessionWindowConfigurationArgs WithTimeoutInMinutes(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetDeltaTimeSessionWindowConfigurationArgs @selfRef, global::System.Int32 timeoutInMinutes)
    {
        @selfRef.TimeoutInMinutes = timeoutInMinutes;
        return @selfRef;
    }

}
