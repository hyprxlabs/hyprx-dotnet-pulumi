// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Monitor.Inputs;

namespace Pulumi.AzureNative.Monitor;

public static partial class MetricAlertSingleResourceMultipleMetricCriteriaArgsExtensions
{
    public static global::Pulumi.AzureNative.Monitor.Inputs.MetricAlertSingleResourceMultipleMetricCriteriaArgs WithAllOf(this global::Pulumi.AzureNative.Monitor.Inputs.MetricAlertSingleResourceMultipleMetricCriteriaArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.MetricCriteriaArgs> allOf)
    {
        @selfRef.AllOf = allOf;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.MetricAlertSingleResourceMultipleMetricCriteriaArgs WithAllOf(this global::Pulumi.AzureNative.Monitor.Inputs.MetricAlertSingleResourceMultipleMetricCriteriaArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.MetricCriteriaArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.MetricCriteriaArgs>();
        @configure(@list);
        @selfRef.AllOf = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.MetricAlertSingleResourceMultipleMetricCriteriaArgs WithAllOf(this global::Pulumi.AzureNative.Monitor.Inputs.MetricAlertSingleResourceMultipleMetricCriteriaArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Monitor.Inputs.MetricCriteriaArgs>> @create)
    {
        @selfRef.AllOf = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.MetricAlertSingleResourceMultipleMetricCriteriaArgs WithOdataType(this global::Pulumi.AzureNative.Monitor.Inputs.MetricAlertSingleResourceMultipleMetricCriteriaArgs @selfRef, global::System.String odataType)
    {
        @selfRef.OdataType = odataType;
        return @selfRef;
    }

}
