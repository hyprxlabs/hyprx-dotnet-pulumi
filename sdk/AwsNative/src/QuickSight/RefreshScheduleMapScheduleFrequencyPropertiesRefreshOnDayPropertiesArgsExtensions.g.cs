// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class RefreshScheduleMapScheduleFrequencyPropertiesRefreshOnDayPropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.RefreshScheduleMapScheduleFrequencyPropertiesRefreshOnDayPropertiesArgs WithDayOfMonth(this global::Pulumi.AwsNative.QuickSight.Inputs.RefreshScheduleMapScheduleFrequencyPropertiesRefreshOnDayPropertiesArgs @selfRef, global::System.String dayOfMonth)
    {
        @selfRef.DayOfMonth = dayOfMonth;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.RefreshScheduleMapScheduleFrequencyPropertiesRefreshOnDayPropertiesArgs WithDayOfWeek(this global::Pulumi.AwsNative.QuickSight.Inputs.RefreshScheduleMapScheduleFrequencyPropertiesRefreshOnDayPropertiesArgs @selfRef, global::Pulumi.AwsNative.QuickSight.RefreshScheduleMapScheduleFrequencyPropertiesRefreshOnDayPropertiesDayOfWeek dayOfWeek)
    {
        @selfRef.DayOfWeek = dayOfWeek;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.RefreshScheduleMapScheduleFrequencyPropertiesRefreshOnDayPropertiesArgs WithDayOfWeek(this global::Pulumi.AwsNative.QuickSight.Inputs.RefreshScheduleMapScheduleFrequencyPropertiesRefreshOnDayPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.RefreshScheduleMapScheduleFrequencyPropertiesRefreshOnDayPropertiesDayOfWeek> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.RefreshScheduleMapScheduleFrequencyPropertiesRefreshOnDayPropertiesDayOfWeek>();
        @configure(@item);
        @selfRef.DayOfWeek = @item;
        return @selfRef;
    }

}
