// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisComputationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithForecast(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisForecastComputationArgs forecast)
    {
        @selfRef.Forecast = forecast;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithForecast(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisForecastComputationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisForecastComputationArgs();
        @configure(@item);
        @selfRef.Forecast = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithGrowthRate(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGrowthRateComputationArgs growthRate)
    {
        @selfRef.GrowthRate = growthRate;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithGrowthRate(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGrowthRateComputationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGrowthRateComputationArgs();
        @configure(@item);
        @selfRef.GrowthRate = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithMaximumMinimum(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisMaximumMinimumComputationArgs maximumMinimum)
    {
        @selfRef.MaximumMinimum = maximumMinimum;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithMaximumMinimum(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisMaximumMinimumComputationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisMaximumMinimumComputationArgs();
        @configure(@item);
        @selfRef.MaximumMinimum = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithMetricComparison(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisMetricComparisonComputationArgs metricComparison)
    {
        @selfRef.MetricComparison = metricComparison;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithMetricComparison(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisMetricComparisonComputationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisMetricComparisonComputationArgs();
        @configure(@item);
        @selfRef.MetricComparison = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithPeriodOverPeriod(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPeriodOverPeriodComputationArgs periodOverPeriod)
    {
        @selfRef.PeriodOverPeriod = periodOverPeriod;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithPeriodOverPeriod(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPeriodOverPeriodComputationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPeriodOverPeriodComputationArgs();
        @configure(@item);
        @selfRef.PeriodOverPeriod = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithPeriodToDate(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPeriodToDateComputationArgs periodToDate)
    {
        @selfRef.PeriodToDate = periodToDate;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithPeriodToDate(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPeriodToDateComputationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPeriodToDateComputationArgs();
        @configure(@item);
        @selfRef.PeriodToDate = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithTopBottomMovers(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTopBottomMoversComputationArgs topBottomMovers)
    {
        @selfRef.TopBottomMovers = topBottomMovers;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithTopBottomMovers(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTopBottomMoversComputationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTopBottomMoversComputationArgs();
        @configure(@item);
        @selfRef.TopBottomMovers = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithTopBottomRanked(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTopBottomRankedComputationArgs topBottomRanked)
    {
        @selfRef.TopBottomRanked = topBottomRanked;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithTopBottomRanked(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTopBottomRankedComputationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTopBottomRankedComputationArgs();
        @configure(@item);
        @selfRef.TopBottomRanked = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithTotalAggregation(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTotalAggregationComputationArgs totalAggregation)
    {
        @selfRef.TotalAggregation = totalAggregation;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithTotalAggregation(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTotalAggregationComputationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTotalAggregationComputationArgs();
        @configure(@item);
        @selfRef.TotalAggregation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithUniqueValues(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisUniqueValuesComputationArgs uniqueValues)
    {
        @selfRef.UniqueValues = uniqueValues;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs WithUniqueValues(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisComputationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisUniqueValuesComputationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisUniqueValuesComputationArgs();
        @configure(@item);
        @selfRef.UniqueValues = @item;
        return @selfRef;
    }

}
