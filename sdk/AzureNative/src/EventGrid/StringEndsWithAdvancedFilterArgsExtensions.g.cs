// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.EventGrid.Inputs;

namespace Pulumi.AzureNative.EventGrid;

public static partial class StringEndsWithAdvancedFilterArgsExtensions
{
    public static global::Pulumi.AzureNative.EventGrid.Inputs.StringEndsWithAdvancedFilterArgs WithKey(this global::Pulumi.AzureNative.EventGrid.Inputs.StringEndsWithAdvancedFilterArgs @selfRef, global::System.String key)
    {
        @selfRef.Key = key;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.StringEndsWithAdvancedFilterArgs WithOperatorType(this global::Pulumi.AzureNative.EventGrid.Inputs.StringEndsWithAdvancedFilterArgs @selfRef, global::System.String operatorType)
    {
        @selfRef.OperatorType = operatorType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.StringEndsWithAdvancedFilterArgs WithValues(this global::Pulumi.AzureNative.EventGrid.Inputs.StringEndsWithAdvancedFilterArgs @selfRef, global::System.Collections.Generic.List<global::System.String> values)
    {
        @selfRef.Values = values;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.StringEndsWithAdvancedFilterArgs WithValues(this global::Pulumi.AzureNative.EventGrid.Inputs.StringEndsWithAdvancedFilterArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Values = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.StringEndsWithAdvancedFilterArgs WithValues(this global::Pulumi.AzureNative.EventGrid.Inputs.StringEndsWithAdvancedFilterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Values = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
