// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplatePivotTableDataPathOptionArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTableDataPathOptionArgs WithDataPathList(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTableDataPathOptionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDataPathValueArgs> dataPathList)
    {
        @selfRef.DataPathList = dataPathList;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTableDataPathOptionArgs WithDataPathList(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTableDataPathOptionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDataPathValueArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDataPathValueArgs>();
        @configure(@list);
        @selfRef.DataPathList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTableDataPathOptionArgs WithDataPathList(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTableDataPathOptionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDataPathValueArgs>> @create)
    {
        @selfRef.DataPathList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTableDataPathOptionArgs WithWidth(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTableDataPathOptionArgs @selfRef, global::System.String width)
    {
        @selfRef.Width = width;
        return @selfRef;
    }

}
