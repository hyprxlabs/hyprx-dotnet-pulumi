// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.InspectorV2.Inputs;

namespace Pulumi.AwsNative.InspectorV2;

public static partial class CisScanConfigurationMonthlyScheduleArgsExtensions
{
    public static global::Pulumi.AwsNative.InspectorV2.Inputs.CisScanConfigurationMonthlyScheduleArgs WithDay(this global::Pulumi.AwsNative.InspectorV2.Inputs.CisScanConfigurationMonthlyScheduleArgs @selfRef, global::Pulumi.AwsNative.InspectorV2.CisScanConfigurationDay day)
    {
        @selfRef.Day = day;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.InspectorV2.Inputs.CisScanConfigurationMonthlyScheduleArgs WithDay(this global::Pulumi.AwsNative.InspectorV2.Inputs.CisScanConfigurationMonthlyScheduleArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.InspectorV2.CisScanConfigurationDay> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.InspectorV2.CisScanConfigurationDay>();
        @configure(@item);
        @selfRef.Day = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.InspectorV2.Inputs.CisScanConfigurationMonthlyScheduleArgs WithStartTime(this global::Pulumi.AwsNative.InspectorV2.Inputs.CisScanConfigurationMonthlyScheduleArgs @selfRef, global::Pulumi.AwsNative.InspectorV2.Inputs.CisScanConfigurationTimeArgs startTime)
    {
        @selfRef.StartTime = startTime;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.InspectorV2.Inputs.CisScanConfigurationMonthlyScheduleArgs WithStartTime(this global::Pulumi.AwsNative.InspectorV2.Inputs.CisScanConfigurationMonthlyScheduleArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.InspectorV2.Inputs.CisScanConfigurationTimeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.InspectorV2.Inputs.CisScanConfigurationTimeArgs();
        @configure(@item);
        @selfRef.StartTime = @item;
        return @selfRef;
    }

}
