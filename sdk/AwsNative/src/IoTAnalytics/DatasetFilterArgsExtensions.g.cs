// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTAnalytics.Inputs;

namespace Pulumi.AwsNative.IoTAnalytics;

public static partial class DatasetFilterArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetFilterArgs WithDeltaTime(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetFilterArgs @selfRef, global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetDeltaTimeArgs deltaTime)
    {
        @selfRef.DeltaTime = deltaTime;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetFilterArgs WithDeltaTime(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetFilterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetDeltaTimeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetDeltaTimeArgs();
        @configure(@item);
        @selfRef.DeltaTime = @item;
        return @selfRef;
    }

}
