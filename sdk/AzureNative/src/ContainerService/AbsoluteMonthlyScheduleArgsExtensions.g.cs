// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerService.Inputs;

namespace Pulumi.AzureNative.ContainerService;

public static partial class AbsoluteMonthlyScheduleArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerService.Inputs.AbsoluteMonthlyScheduleArgs WithDayOfMonth(this global::Pulumi.AzureNative.ContainerService.Inputs.AbsoluteMonthlyScheduleArgs @selfRef, global::System.Int32 dayOfMonth)
    {
        @selfRef.DayOfMonth = dayOfMonth;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.AbsoluteMonthlyScheduleArgs WithIntervalMonths(this global::Pulumi.AzureNative.ContainerService.Inputs.AbsoluteMonthlyScheduleArgs @selfRef, global::System.Int32 intervalMonths)
    {
        @selfRef.IntervalMonths = intervalMonths;
        return @selfRef;
    }

}
