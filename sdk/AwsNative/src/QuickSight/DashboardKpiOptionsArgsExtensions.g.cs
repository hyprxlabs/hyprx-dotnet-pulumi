// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardKpiOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs WithComparison(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardComparisonConfigurationArgs comparison)
    {
        @selfRef.Comparison = comparison;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs WithComparison(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardComparisonConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardComparisonConfigurationArgs();
        @configure(@item);
        @selfRef.Comparison = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs WithPrimaryValueDisplayType(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.DashboardPrimaryValueDisplayType primaryValueDisplayType)
    {
        @selfRef.PrimaryValueDisplayType = primaryValueDisplayType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs WithPrimaryValueDisplayType(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.DashboardPrimaryValueDisplayType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.DashboardPrimaryValueDisplayType>();
        @configure(@item);
        @selfRef.PrimaryValueDisplayType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs WithPrimaryValueFontConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFontConfigurationArgs primaryValueFontConfiguration)
    {
        @selfRef.PrimaryValueFontConfiguration = primaryValueFontConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs WithPrimaryValueFontConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFontConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFontConfigurationArgs();
        @configure(@item);
        @selfRef.PrimaryValueFontConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs WithProgressBar(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardProgressBarOptionsArgs progressBar)
    {
        @selfRef.ProgressBar = progressBar;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs WithProgressBar(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardProgressBarOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardProgressBarOptionsArgs();
        @configure(@item);
        @selfRef.ProgressBar = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs WithSecondaryValue(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSecondaryValueOptionsArgs secondaryValue)
    {
        @selfRef.SecondaryValue = secondaryValue;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs WithSecondaryValue(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSecondaryValueOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSecondaryValueOptionsArgs();
        @configure(@item);
        @selfRef.SecondaryValue = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs WithSecondaryValueFontConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFontConfigurationArgs secondaryValueFontConfiguration)
    {
        @selfRef.SecondaryValueFontConfiguration = secondaryValueFontConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs WithSecondaryValueFontConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFontConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFontConfigurationArgs();
        @configure(@item);
        @selfRef.SecondaryValueFontConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs WithSparkline(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiSparklineOptionsArgs sparkline)
    {
        @selfRef.Sparkline = sparkline;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs WithSparkline(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiSparklineOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiSparklineOptionsArgs();
        @configure(@item);
        @selfRef.Sparkline = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs WithTrendArrows(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTrendArrowOptionsArgs trendArrows)
    {
        @selfRef.TrendArrows = trendArrows;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs WithTrendArrows(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTrendArrowOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTrendArrowOptionsArgs();
        @configure(@item);
        @selfRef.TrendArrows = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs WithVisualLayoutOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiVisualLayoutOptionsArgs visualLayoutOptions)
    {
        @selfRef.VisualLayoutOptions = visualLayoutOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs WithVisualLayoutOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiVisualLayoutOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiVisualLayoutOptionsArgs();
        @configure(@item);
        @selfRef.VisualLayoutOptions = @item;
        return @selfRef;
    }

}
