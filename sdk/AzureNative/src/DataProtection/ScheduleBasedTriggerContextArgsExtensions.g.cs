// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataProtection.Inputs;

namespace Pulumi.AzureNative.DataProtection;

public static partial class ScheduleBasedTriggerContextArgsExtensions
{
    public static global::Pulumi.AzureNative.DataProtection.Inputs.ScheduleBasedTriggerContextArgs WithObjectType(this global::Pulumi.AzureNative.DataProtection.Inputs.ScheduleBasedTriggerContextArgs @selfRef, global::System.String objectType)
    {
        @selfRef.ObjectType = objectType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataProtection.Inputs.ScheduleBasedTriggerContextArgs WithSchedule(this global::Pulumi.AzureNative.DataProtection.Inputs.ScheduleBasedTriggerContextArgs @selfRef, global::Pulumi.AzureNative.DataProtection.Inputs.BackupScheduleArgs schedule)
    {
        @selfRef.Schedule = schedule;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataProtection.Inputs.ScheduleBasedTriggerContextArgs WithSchedule(this global::Pulumi.AzureNative.DataProtection.Inputs.ScheduleBasedTriggerContextArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataProtection.Inputs.BackupScheduleArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataProtection.Inputs.BackupScheduleArgs();
        @configure(@item);
        @selfRef.Schedule = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataProtection.Inputs.ScheduleBasedTriggerContextArgs WithTaggingCriteria(this global::Pulumi.AzureNative.DataProtection.Inputs.ScheduleBasedTriggerContextArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataProtection.Inputs.TaggingCriteriaArgs> taggingCriteria)
    {
        @selfRef.TaggingCriteria = taggingCriteria;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataProtection.Inputs.ScheduleBasedTriggerContextArgs WithTaggingCriteria(this global::Pulumi.AzureNative.DataProtection.Inputs.ScheduleBasedTriggerContextArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataProtection.Inputs.TaggingCriteriaArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataProtection.Inputs.TaggingCriteriaArgs>();
        @configure(@list);
        @selfRef.TaggingCriteria = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataProtection.Inputs.ScheduleBasedTriggerContextArgs WithTaggingCriteria(this global::Pulumi.AzureNative.DataProtection.Inputs.ScheduleBasedTriggerContextArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DataProtection.Inputs.TaggingCriteriaArgs>> @create)
    {
        @selfRef.TaggingCriteria = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
