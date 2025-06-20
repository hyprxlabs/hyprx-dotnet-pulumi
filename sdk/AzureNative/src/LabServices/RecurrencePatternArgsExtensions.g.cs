// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.LabServices.Inputs;

namespace Pulumi.AzureNative.LabServices;

public static partial class RecurrencePatternArgsExtensions
{
    public static global::Pulumi.AzureNative.LabServices.Inputs.RecurrencePatternArgs WithExpirationDate(this global::Pulumi.AzureNative.LabServices.Inputs.RecurrencePatternArgs @selfRef, global::System.String expirationDate)
    {
        @selfRef.ExpirationDate = expirationDate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.LabServices.Inputs.RecurrencePatternArgs WithFrequency(this global::Pulumi.AzureNative.LabServices.Inputs.RecurrencePatternArgs @selfRef, global::Pulumi.AzureNative.LabServices.RecurrenceFrequency frequency)
    {
        @selfRef.Frequency = frequency;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.LabServices.Inputs.RecurrencePatternArgs WithFrequency(this global::Pulumi.AzureNative.LabServices.Inputs.RecurrencePatternArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.LabServices.RecurrenceFrequency> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.LabServices.RecurrenceFrequency>();
        @configure(@item);
        @selfRef.Frequency = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.LabServices.Inputs.RecurrencePatternArgs WithInterval(this global::Pulumi.AzureNative.LabServices.Inputs.RecurrencePatternArgs @selfRef, global::System.Int32 interval)
    {
        @selfRef.Interval = interval;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.LabServices.Inputs.RecurrencePatternArgs WithWeekDays(this global::Pulumi.AzureNative.LabServices.Inputs.RecurrencePatternArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.LabServices.WeekDay> weekDays)
    {
        @selfRef.WeekDays = weekDays;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.LabServices.Inputs.RecurrencePatternArgs WithWeekDays(this global::Pulumi.AzureNative.LabServices.Inputs.RecurrencePatternArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.LabServices.WeekDay>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.LabServices.WeekDay>();
        @configure(@list);
        @selfRef.WeekDays = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.LabServices.Inputs.RecurrencePatternArgs WithWeekDays(this global::Pulumi.AzureNative.LabServices.Inputs.RecurrencePatternArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.LabServices.WeekDay>> @create)
    {
        @selfRef.WeekDays = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
