// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Monitor.Inputs;

namespace Pulumi.AzureNative.Monitor;

public static partial class ScaleRuleMetricDimensionArgsExtensions
{
    public static global::Pulumi.AzureNative.Monitor.Inputs.ScaleRuleMetricDimensionArgs WithDimensionName(this global::Pulumi.AzureNative.Monitor.Inputs.ScaleRuleMetricDimensionArgs @selfRef, global::System.String dimensionName)
    {
        @selfRef.DimensionName = dimensionName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.ScaleRuleMetricDimensionArgs WithOperator(this global::Pulumi.AzureNative.Monitor.Inputs.ScaleRuleMetricDimensionArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Monitor.ScaleRuleMetricDimensionOperationType> @operator)
    {
        @selfRef.Operator = @operator;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.ScaleRuleMetricDimensionArgs WithValues(this global::Pulumi.AzureNative.Monitor.Inputs.ScaleRuleMetricDimensionArgs @selfRef, global::System.Collections.Generic.List<global::System.String> values)
    {
        @selfRef.Values = values;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.ScaleRuleMetricDimensionArgs WithValues(this global::Pulumi.AzureNative.Monitor.Inputs.ScaleRuleMetricDimensionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Values = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.ScaleRuleMetricDimensionArgs WithValues(this global::Pulumi.AzureNative.Monitor.Inputs.ScaleRuleMetricDimensionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Values = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
