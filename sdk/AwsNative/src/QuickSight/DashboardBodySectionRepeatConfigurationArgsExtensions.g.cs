// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardBodySectionRepeatConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatConfigurationArgs WithDimensionConfigurations(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatDimensionConfigurationArgs> dimensionConfigurations)
    {
        @selfRef.DimensionConfigurations = dimensionConfigurations;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatConfigurationArgs WithDimensionConfigurations(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatDimensionConfigurationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatDimensionConfigurationArgs>();
        @configure(@list);
        @selfRef.DimensionConfigurations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatConfigurationArgs WithDimensionConfigurations(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatDimensionConfigurationArgs>> @create)
    {
        @selfRef.DimensionConfigurations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatConfigurationArgs WithNonRepeatingVisuals(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::System.String> nonRepeatingVisuals)
    {
        @selfRef.NonRepeatingVisuals = nonRepeatingVisuals;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatConfigurationArgs WithNonRepeatingVisuals(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.NonRepeatingVisuals = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatConfigurationArgs WithNonRepeatingVisuals(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.NonRepeatingVisuals = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatConfigurationArgs WithPageBreakConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatPageBreakConfigurationArgs pageBreakConfiguration)
    {
        @selfRef.PageBreakConfiguration = pageBreakConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatConfigurationArgs WithPageBreakConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatPageBreakConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatPageBreakConfigurationArgs();
        @configure(@item);
        @selfRef.PageBreakConfiguration = @item;
        return @selfRef;
    }

}
