// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateParameterSelectableValuesArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateParameterSelectableValuesArgs WithLinkToDataSetColumn(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateParameterSelectableValuesArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColumnIdentifierArgs linkToDataSetColumn)
    {
        @selfRef.LinkToDataSetColumn = linkToDataSetColumn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateParameterSelectableValuesArgs WithLinkToDataSetColumn(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateParameterSelectableValuesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColumnIdentifierArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColumnIdentifierArgs();
        @configure(@item);
        @selfRef.LinkToDataSetColumn = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateParameterSelectableValuesArgs WithValues(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateParameterSelectableValuesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> values)
    {
        @selfRef.Values = values;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateParameterSelectableValuesArgs WithValues(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateParameterSelectableValuesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Values = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateParameterSelectableValuesArgs WithValues(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateParameterSelectableValuesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Values = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
