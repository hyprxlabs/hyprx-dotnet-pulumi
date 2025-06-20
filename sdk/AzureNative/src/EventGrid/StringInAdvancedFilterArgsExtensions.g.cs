// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.EventGrid.Inputs;

namespace Pulumi.AzureNative.EventGrid;

public static partial class StringInAdvancedFilterArgsExtensions
{
    public static global::Pulumi.AzureNative.EventGrid.Inputs.StringInAdvancedFilterArgs WithKey(this global::Pulumi.AzureNative.EventGrid.Inputs.StringInAdvancedFilterArgs @selfRef, global::System.String key)
    {
        @selfRef.Key = key;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.StringInAdvancedFilterArgs WithOperatorType(this global::Pulumi.AzureNative.EventGrid.Inputs.StringInAdvancedFilterArgs @selfRef, global::System.String operatorType)
    {
        @selfRef.OperatorType = operatorType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.StringInAdvancedFilterArgs WithValues(this global::Pulumi.AzureNative.EventGrid.Inputs.StringInAdvancedFilterArgs @selfRef, global::System.Collections.Generic.List<global::System.String> values)
    {
        @selfRef.Values = values;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.StringInAdvancedFilterArgs WithValues(this global::Pulumi.AzureNative.EventGrid.Inputs.StringInAdvancedFilterArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Values = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.StringInAdvancedFilterArgs WithValues(this global::Pulumi.AzureNative.EventGrid.Inputs.StringInAdvancedFilterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Values = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
