// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerService.Inputs;

namespace Pulumi.AzureNative.ContainerService;

public static partial class DailyScheduleArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerService.Inputs.DailyScheduleArgs WithIntervalDays(this global::Pulumi.AzureNative.ContainerService.Inputs.DailyScheduleArgs @selfRef, global::System.Int32 intervalDays)
    {
        @selfRef.IntervalDays = intervalDays;
        return @selfRef;
    }

}
