// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Automation.Inputs;

namespace Pulumi.AzureNative.Automation;

public static partial class SUCSchedulePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs WithAdvancedSchedule(this global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs @selfRef, global::Pulumi.AzureNative.Automation.Inputs.AdvancedScheduleArgs advancedSchedule)
    {
        @selfRef.AdvancedSchedule = advancedSchedule;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs WithAdvancedSchedule(this global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Automation.Inputs.AdvancedScheduleArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Automation.Inputs.AdvancedScheduleArgs();
        @configure(@item);
        @selfRef.AdvancedSchedule = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs WithCreationTime(this global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs @selfRef, global::System.String creationTime)
    {
        @selfRef.CreationTime = creationTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs WithDescription(this global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs WithExpiryTime(this global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs @selfRef, global::System.String expiryTime)
    {
        @selfRef.ExpiryTime = expiryTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs WithExpiryTimeOffsetMinutes(this global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs @selfRef, global::System.Double expiryTimeOffsetMinutes)
    {
        @selfRef.ExpiryTimeOffsetMinutes = expiryTimeOffsetMinutes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs WithFrequency(this global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Automation.ScheduleFrequency> frequency)
    {
        @selfRef.Frequency = frequency;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs WithInterval(this global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs @selfRef, global::System.Double interval)
    {
        @selfRef.Interval = interval;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs WithIsEnabled(this global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs @selfRef, bool isEnabled = true)
    {
        @selfRef.IsEnabled = isEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs WithLastModifiedTime(this global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs @selfRef, global::System.String lastModifiedTime)
    {
        @selfRef.LastModifiedTime = lastModifiedTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs WithNextRun(this global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs @selfRef, global::System.String nextRun)
    {
        @selfRef.NextRun = nextRun;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs WithNextRunOffsetMinutes(this global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs @selfRef, global::System.Double nextRunOffsetMinutes)
    {
        @selfRef.NextRunOffsetMinutes = nextRunOffsetMinutes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs WithStartTime(this global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs @selfRef, global::System.String startTime)
    {
        @selfRef.StartTime = startTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs WithTimeZone(this global::Pulumi.AzureNative.Automation.Inputs.SUCSchedulePropertiesArgs @selfRef, global::System.String timeZone)
    {
        @selfRef.TimeZone = timeZone;
        return @selfRef;
    }

}
