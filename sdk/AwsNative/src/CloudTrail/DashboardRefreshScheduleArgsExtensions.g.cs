// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.CloudTrail.Inputs;

namespace Pulumi.AwsNative.CloudTrail;

public static partial class DashboardRefreshScheduleArgsExtensions
{
    public static global::Pulumi.AwsNative.CloudTrail.Inputs.DashboardRefreshScheduleArgs WithFrequency(this global::Pulumi.AwsNative.CloudTrail.Inputs.DashboardRefreshScheduleArgs @selfRef, global::Pulumi.AwsNative.CloudTrail.Inputs.DashboardRefreshScheduleFrequencyPropertiesArgs frequency)
    {
        @selfRef.Frequency = frequency;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudTrail.Inputs.DashboardRefreshScheduleArgs WithFrequency(this global::Pulumi.AwsNative.CloudTrail.Inputs.DashboardRefreshScheduleArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CloudTrail.Inputs.DashboardRefreshScheduleFrequencyPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.CloudTrail.Inputs.DashboardRefreshScheduleFrequencyPropertiesArgs();
        @configure(@item);
        @selfRef.Frequency = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudTrail.Inputs.DashboardRefreshScheduleArgs WithStatus(this global::Pulumi.AwsNative.CloudTrail.Inputs.DashboardRefreshScheduleArgs @selfRef, global::Pulumi.AwsNative.CloudTrail.DashboardRefreshScheduleStatus status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudTrail.Inputs.DashboardRefreshScheduleArgs WithStatus(this global::Pulumi.AwsNative.CloudTrail.Inputs.DashboardRefreshScheduleArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CloudTrail.DashboardRefreshScheduleStatus> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.CloudTrail.DashboardRefreshScheduleStatus>();
        @configure(@item);
        @selfRef.Status = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudTrail.Inputs.DashboardRefreshScheduleArgs WithTimeOfDay(this global::Pulumi.AwsNative.CloudTrail.Inputs.DashboardRefreshScheduleArgs @selfRef, global::System.String timeOfDay)
    {
        @selfRef.TimeOfDay = timeOfDay;
        return @selfRef;
    }

}
