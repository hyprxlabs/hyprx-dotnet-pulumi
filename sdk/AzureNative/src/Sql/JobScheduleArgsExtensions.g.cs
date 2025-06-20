// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Sql.Inputs;

namespace Pulumi.AzureNative.Sql;

public static partial class JobScheduleArgsExtensions
{
    public static global::Pulumi.AzureNative.Sql.Inputs.JobScheduleArgs WithEnabled(this global::Pulumi.AzureNative.Sql.Inputs.JobScheduleArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.Inputs.JobScheduleArgs WithEndTime(this global::Pulumi.AzureNative.Sql.Inputs.JobScheduleArgs @selfRef, global::System.String endTime)
    {
        @selfRef.EndTime = endTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.Inputs.JobScheduleArgs WithInterval(this global::Pulumi.AzureNative.Sql.Inputs.JobScheduleArgs @selfRef, global::System.String interval)
    {
        @selfRef.Interval = interval;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.Inputs.JobScheduleArgs WithStartTime(this global::Pulumi.AzureNative.Sql.Inputs.JobScheduleArgs @selfRef, global::System.String startTime)
    {
        @selfRef.StartTime = startTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.Inputs.JobScheduleArgs WithType(this global::Pulumi.AzureNative.Sql.Inputs.JobScheduleArgs @selfRef, global::Pulumi.AzureNative.Sql.JobScheduleType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Sql.Inputs.JobScheduleArgs WithType(this global::Pulumi.AzureNative.Sql.Inputs.JobScheduleArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Sql.JobScheduleType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.Sql.JobScheduleType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
