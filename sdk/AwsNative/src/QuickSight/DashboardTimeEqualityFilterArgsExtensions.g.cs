// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardTimeEqualityFilterArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs WithColumn(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardColumnIdentifierArgs column)
    {
        @selfRef.Column = column;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs WithColumn(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardColumnIdentifierArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardColumnIdentifierArgs();
        @configure(@item);
        @selfRef.Column = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs WithDefaultFilterControlConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDefaultFilterControlConfigurationArgs defaultFilterControlConfiguration)
    {
        @selfRef.DefaultFilterControlConfiguration = defaultFilterControlConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs WithDefaultFilterControlConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDefaultFilterControlConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDefaultFilterControlConfigurationArgs();
        @configure(@item);
        @selfRef.DefaultFilterControlConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs WithFilterId(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs @selfRef, global::System.String filterId)
    {
        @selfRef.FilterId = filterId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs WithParameterName(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs @selfRef, global::System.String parameterName)
    {
        @selfRef.ParameterName = parameterName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs WithRollingDate(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardRollingDateConfigurationArgs rollingDate)
    {
        @selfRef.RollingDate = rollingDate;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs WithRollingDate(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardRollingDateConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardRollingDateConfigurationArgs();
        @configure(@item);
        @selfRef.RollingDate = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs WithTimeGranularity(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs @selfRef, global::Pulumi.AwsNative.QuickSight.DashboardTimeGranularity timeGranularity)
    {
        @selfRef.TimeGranularity = timeGranularity;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs WithTimeGranularity(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.DashboardTimeGranularity> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.DashboardTimeGranularity>();
        @configure(@item);
        @selfRef.TimeGranularity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs WithValue(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTimeEqualityFilterArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
