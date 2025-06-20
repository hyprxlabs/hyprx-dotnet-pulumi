// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerService.Inputs;

namespace Pulumi.AzureNative.ContainerService;

public static partial class MaintenanceWindowArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerService.Inputs.MaintenanceWindowArgs WithDurationHours(this global::Pulumi.AzureNative.ContainerService.Inputs.MaintenanceWindowArgs @selfRef, global::System.Int32 durationHours)
    {
        @selfRef.DurationHours = durationHours;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.MaintenanceWindowArgs WithNotAllowedDates(this global::Pulumi.AzureNative.ContainerService.Inputs.MaintenanceWindowArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.DateSpanArgs> notAllowedDates)
    {
        @selfRef.NotAllowedDates = notAllowedDates;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.MaintenanceWindowArgs WithNotAllowedDates(this global::Pulumi.AzureNative.ContainerService.Inputs.MaintenanceWindowArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.DateSpanArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.DateSpanArgs>();
        @configure(@list);
        @selfRef.NotAllowedDates = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.MaintenanceWindowArgs WithNotAllowedDates(this global::Pulumi.AzureNative.ContainerService.Inputs.MaintenanceWindowArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ContainerService.Inputs.DateSpanArgs>> @create)
    {
        @selfRef.NotAllowedDates = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.MaintenanceWindowArgs WithSchedule(this global::Pulumi.AzureNative.ContainerService.Inputs.MaintenanceWindowArgs @selfRef, global::Pulumi.AzureNative.ContainerService.Inputs.ScheduleArgs schedule)
    {
        @selfRef.Schedule = schedule;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.MaintenanceWindowArgs WithSchedule(this global::Pulumi.AzureNative.ContainerService.Inputs.MaintenanceWindowArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ContainerService.Inputs.ScheduleArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ContainerService.Inputs.ScheduleArgs();
        @configure(@item);
        @selfRef.Schedule = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.MaintenanceWindowArgs WithStartDate(this global::Pulumi.AzureNative.ContainerService.Inputs.MaintenanceWindowArgs @selfRef, global::System.String startDate)
    {
        @selfRef.StartDate = startDate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.MaintenanceWindowArgs WithStartTime(this global::Pulumi.AzureNative.ContainerService.Inputs.MaintenanceWindowArgs @selfRef, global::System.String startTime)
    {
        @selfRef.StartTime = startTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.MaintenanceWindowArgs WithUtcOffset(this global::Pulumi.AzureNative.ContainerService.Inputs.MaintenanceWindowArgs @selfRef, global::System.String utcOffset)
    {
        @selfRef.UtcOffset = utcOffset;
        return @selfRef;
    }

}
