// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardPluginVisualFieldWellArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs WithAxisName(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs @selfRef, global::Pulumi.AwsNative.QuickSight.DashboardPluginVisualAxisName axisName)
    {
        @selfRef.AxisName = axisName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs WithAxisName(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.DashboardPluginVisualAxisName> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.DashboardPluginVisualAxisName>();
        @configure(@item);
        @selfRef.AxisName = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs WithDimensions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDimensionFieldArgs> dimensions)
    {
        @selfRef.Dimensions = dimensions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs WithDimensions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDimensionFieldArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDimensionFieldArgs>();
        @configure(@list);
        @selfRef.Dimensions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs WithDimensions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDimensionFieldArgs>> @create)
    {
        @selfRef.Dimensions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs WithMeasures(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardMeasureFieldArgs> measures)
    {
        @selfRef.Measures = measures;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs WithMeasures(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardMeasureFieldArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardMeasureFieldArgs>();
        @configure(@list);
        @selfRef.Measures = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs WithMeasures(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardMeasureFieldArgs>> @create)
    {
        @selfRef.Measures = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs WithUnaggregated(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardUnaggregatedFieldArgs> unaggregated)
    {
        @selfRef.Unaggregated = unaggregated;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs WithUnaggregated(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardUnaggregatedFieldArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardUnaggregatedFieldArgs>();
        @configure(@list);
        @selfRef.Unaggregated = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs WithUnaggregated(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualFieldWellArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardUnaggregatedFieldArgs>> @create)
    {
        @selfRef.Unaggregated = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
