// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DevTestLab;

public static partial class GlobalScheduleArgsExtensions
{
    public static global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs WithDailyRecurrence(this global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs @selfRef, global::Pulumi.AzureNative.DevTestLab.Inputs.DayDetailsArgs dailyRecurrence)
    {
        @selfRef.DailyRecurrence = dailyRecurrence;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs WithDailyRecurrence(this global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DevTestLab.Inputs.DayDetailsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DevTestLab.Inputs.DayDetailsArgs();
        @configure(@item);
        @selfRef.DailyRecurrence = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs WithHourlyRecurrence(this global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs @selfRef, global::Pulumi.AzureNative.DevTestLab.Inputs.HourDetailsArgs hourlyRecurrence)
    {
        @selfRef.HourlyRecurrence = hourlyRecurrence;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs WithHourlyRecurrence(this global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DevTestLab.Inputs.HourDetailsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DevTestLab.Inputs.HourDetailsArgs();
        @configure(@item);
        @selfRef.HourlyRecurrence = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs WithLocation(this global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs WithName(this global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs WithNotificationSettings(this global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs @selfRef, global::Pulumi.AzureNative.DevTestLab.Inputs.NotificationSettingsArgs notificationSettings)
    {
        @selfRef.NotificationSettings = notificationSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs WithNotificationSettings(this global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DevTestLab.Inputs.NotificationSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DevTestLab.Inputs.NotificationSettingsArgs();
        @configure(@item);
        @selfRef.NotificationSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs WithResourceGroupName(this global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs WithStatus(this global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DevTestLab.EnableStatus> status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs WithTags(this global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs WithTags(this global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs WithTags(this global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs WithTargetResourceId(this global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs @selfRef, global::System.String targetResourceId)
    {
        @selfRef.TargetResourceId = targetResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs WithTaskType(this global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs @selfRef, global::System.String taskType)
    {
        @selfRef.TaskType = taskType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs WithTimeZoneId(this global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs @selfRef, global::System.String timeZoneId)
    {
        @selfRef.TimeZoneId = timeZoneId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs WithWeeklyRecurrence(this global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs @selfRef, global::Pulumi.AzureNative.DevTestLab.Inputs.WeekDetailsArgs weeklyRecurrence)
    {
        @selfRef.WeeklyRecurrence = weeklyRecurrence;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs WithWeeklyRecurrence(this global::Pulumi.AzureNative.DevTestLab.GlobalScheduleArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DevTestLab.Inputs.WeekDetailsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DevTestLab.Inputs.WeekDetailsArgs();
        @configure(@item);
        @selfRef.WeeklyRecurrence = @item;
        return @selfRef;
    }

}
