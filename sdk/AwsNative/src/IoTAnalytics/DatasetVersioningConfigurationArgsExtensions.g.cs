// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTAnalytics.Inputs;

namespace Pulumi.AwsNative.IoTAnalytics;

public static partial class DatasetVersioningConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetVersioningConfigurationArgs WithMaxVersions(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetVersioningConfigurationArgs @selfRef, global::System.Int32 maxVersions)
    {
        @selfRef.MaxVersions = maxVersions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetVersioningConfigurationArgs WithUnlimited(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetVersioningConfigurationArgs @selfRef, bool unlimited = true)
    {
        @selfRef.Unlimited = unlimited;
        return @selfRef;
    }

}
