// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateMeasureFieldArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs WithCalculatedMeasureField(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateCalculatedMeasureFieldArgs calculatedMeasureField)
    {
        @selfRef.CalculatedMeasureField = calculatedMeasureField;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs WithCalculatedMeasureField(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateCalculatedMeasureFieldArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateCalculatedMeasureFieldArgs();
        @configure(@item);
        @selfRef.CalculatedMeasureField = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs WithCategoricalMeasureField(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateCategoricalMeasureFieldArgs categoricalMeasureField)
    {
        @selfRef.CategoricalMeasureField = categoricalMeasureField;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs WithCategoricalMeasureField(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateCategoricalMeasureFieldArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateCategoricalMeasureFieldArgs();
        @configure(@item);
        @selfRef.CategoricalMeasureField = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs WithDateMeasureField(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDateMeasureFieldArgs dateMeasureField)
    {
        @selfRef.DateMeasureField = dateMeasureField;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs WithDateMeasureField(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDateMeasureFieldArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDateMeasureFieldArgs();
        @configure(@item);
        @selfRef.DateMeasureField = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs WithNumericalMeasureField(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateNumericalMeasureFieldArgs numericalMeasureField)
    {
        @selfRef.NumericalMeasureField = numericalMeasureField;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs WithNumericalMeasureField(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateMeasureFieldArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateNumericalMeasureFieldArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateNumericalMeasureFieldArgs();
        @configure(@item);
        @selfRef.NumericalMeasureField = @item;
        return @selfRef;
    }

}
