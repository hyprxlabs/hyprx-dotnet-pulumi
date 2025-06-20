// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisTimeBasedForecastPropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTimeBasedForecastPropertiesArgs WithLowerBoundary(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTimeBasedForecastPropertiesArgs @selfRef, global::System.Double lowerBoundary)
    {
        @selfRef.LowerBoundary = lowerBoundary;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTimeBasedForecastPropertiesArgs WithPeriodsBackward(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTimeBasedForecastPropertiesArgs @selfRef, global::System.Double periodsBackward)
    {
        @selfRef.PeriodsBackward = periodsBackward;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTimeBasedForecastPropertiesArgs WithPeriodsForward(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTimeBasedForecastPropertiesArgs @selfRef, global::System.Double periodsForward)
    {
        @selfRef.PeriodsForward = periodsForward;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTimeBasedForecastPropertiesArgs WithPredictionInterval(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTimeBasedForecastPropertiesArgs @selfRef, global::System.Double predictionInterval)
    {
        @selfRef.PredictionInterval = predictionInterval;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTimeBasedForecastPropertiesArgs WithSeasonality(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTimeBasedForecastPropertiesArgs @selfRef, global::System.Double seasonality)
    {
        @selfRef.Seasonality = seasonality;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTimeBasedForecastPropertiesArgs WithUpperBoundary(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTimeBasedForecastPropertiesArgs @selfRef, global::System.Double upperBoundary)
    {
        @selfRef.UpperBoundary = upperBoundary;
        return @selfRef;
    }

}
