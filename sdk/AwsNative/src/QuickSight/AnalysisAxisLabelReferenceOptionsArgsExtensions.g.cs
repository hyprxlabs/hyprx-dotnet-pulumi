// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisAxisLabelReferenceOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAxisLabelReferenceOptionsArgs WithColumn(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAxisLabelReferenceOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColumnIdentifierArgs column)
    {
        @selfRef.Column = column;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAxisLabelReferenceOptionsArgs WithColumn(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAxisLabelReferenceOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColumnIdentifierArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisColumnIdentifierArgs();
        @configure(@item);
        @selfRef.Column = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAxisLabelReferenceOptionsArgs WithFieldId(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAxisLabelReferenceOptionsArgs @selfRef, global::System.String fieldId)
    {
        @selfRef.FieldId = fieldId;
        return @selfRef;
    }

}
