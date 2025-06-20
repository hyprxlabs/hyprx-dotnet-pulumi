// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisAggregationFunctionArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAggregationFunctionArgs WithAttributeAggregationFunction(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAggregationFunctionArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAttributeAggregationFunctionArgs attributeAggregationFunction)
    {
        @selfRef.AttributeAggregationFunction = attributeAggregationFunction;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAggregationFunctionArgs WithAttributeAggregationFunction(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAggregationFunctionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAttributeAggregationFunctionArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAttributeAggregationFunctionArgs();
        @configure(@item);
        @selfRef.AttributeAggregationFunction = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAggregationFunctionArgs WithCategoricalAggregationFunction(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAggregationFunctionArgs @selfRef, global::Pulumi.AwsNative.QuickSight.AnalysisCategoricalAggregationFunction categoricalAggregationFunction)
    {
        @selfRef.CategoricalAggregationFunction = categoricalAggregationFunction;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAggregationFunctionArgs WithCategoricalAggregationFunction(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAggregationFunctionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.AnalysisCategoricalAggregationFunction> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.AnalysisCategoricalAggregationFunction>();
        @configure(@item);
        @selfRef.CategoricalAggregationFunction = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAggregationFunctionArgs WithDateAggregationFunction(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAggregationFunctionArgs @selfRef, global::Pulumi.AwsNative.QuickSight.AnalysisDateAggregationFunction dateAggregationFunction)
    {
        @selfRef.DateAggregationFunction = dateAggregationFunction;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAggregationFunctionArgs WithDateAggregationFunction(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAggregationFunctionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.AnalysisDateAggregationFunction> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.AnalysisDateAggregationFunction>();
        @configure(@item);
        @selfRef.DateAggregationFunction = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAggregationFunctionArgs WithNumericalAggregationFunction(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAggregationFunctionArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisNumericalAggregationFunctionArgs numericalAggregationFunction)
    {
        @selfRef.NumericalAggregationFunction = numericalAggregationFunction;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAggregationFunctionArgs WithNumericalAggregationFunction(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAggregationFunctionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisNumericalAggregationFunctionArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisNumericalAggregationFunctionArgs();
        @configure(@item);
        @selfRef.NumericalAggregationFunction = @item;
        return @selfRef;
    }

}
