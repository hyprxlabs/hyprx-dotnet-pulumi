// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.SecurityInsights.Inputs;

namespace Pulumi.AzureNative.SecurityInsights;

public static partial class LogArgsExtensions
{
    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs WithBulkSize(this global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs @selfRef, global::System.Int32 bulkSize)
    {
        @selfRef.BulkSize = bulkSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs WithFilters(this global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs @selfRef, global::System.Collections.Generic.List<global::System.String> filters)
    {
        @selfRef.Filters = filters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs WithFilters(this global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Filters = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs WithFilters(this global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Filters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs WithIngestionType(this global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.SecurityInsights.IngestionType> ingestionType)
    {
        @selfRef.IngestionType = ingestionType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs WithScheduleInterval(this global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs @selfRef, global::System.Int32 scheduleInterval)
    {
        @selfRef.ScheduleInterval = scheduleInterval;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs WithStatus(this global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.SecurityInsights.LogStatusType> status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs WithType(this global::Pulumi.AzureNative.SecurityInsights.Inputs.LogArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.SecurityInsights.LogType> type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
