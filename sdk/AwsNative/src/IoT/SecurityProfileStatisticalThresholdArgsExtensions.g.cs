// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoT.Inputs;

namespace Pulumi.AwsNative.IoT;

public static partial class SecurityProfileStatisticalThresholdArgsExtensions
{
    public static global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileStatisticalThresholdArgs WithStatistic(this global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileStatisticalThresholdArgs @selfRef, global::Pulumi.AwsNative.IoT.SecurityProfileStatisticalThresholdStatistic statistic)
    {
        @selfRef.Statistic = statistic;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileStatisticalThresholdArgs WithStatistic(this global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileStatisticalThresholdArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoT.SecurityProfileStatisticalThresholdStatistic> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.IoT.SecurityProfileStatisticalThresholdStatistic>();
        @configure(@item);
        @selfRef.Statistic = @item;
        return @selfRef;
    }

}
