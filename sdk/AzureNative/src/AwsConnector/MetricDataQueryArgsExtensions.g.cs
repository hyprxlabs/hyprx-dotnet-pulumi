// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class MetricDataQueryArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MetricDataQueryArgs WithAccountId(this global::Pulumi.AzureNative.AwsConnector.Inputs.MetricDataQueryArgs @selfRef, global::System.String accountId)
    {
        @selfRef.AccountId = accountId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MetricDataQueryArgs WithExpression(this global::Pulumi.AzureNative.AwsConnector.Inputs.MetricDataQueryArgs @selfRef, global::System.String expression)
    {
        @selfRef.Expression = expression;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MetricDataQueryArgs WithId(this global::Pulumi.AzureNative.AwsConnector.Inputs.MetricDataQueryArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MetricDataQueryArgs WithLabel(this global::Pulumi.AzureNative.AwsConnector.Inputs.MetricDataQueryArgs @selfRef, global::System.String label)
    {
        @selfRef.Label = label;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MetricDataQueryArgs WithMetricStat(this global::Pulumi.AzureNative.AwsConnector.Inputs.MetricDataQueryArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.MetricStatArgs metricStat)
    {
        @selfRef.MetricStat = metricStat;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MetricDataQueryArgs WithMetricStat(this global::Pulumi.AzureNative.AwsConnector.Inputs.MetricDataQueryArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.MetricStatArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.MetricStatArgs();
        @configure(@item);
        @selfRef.MetricStat = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MetricDataQueryArgs WithPeriod(this global::Pulumi.AzureNative.AwsConnector.Inputs.MetricDataQueryArgs @selfRef, global::System.Int32 period)
    {
        @selfRef.Period = period;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MetricDataQueryArgs WithReturnData(this global::Pulumi.AzureNative.AwsConnector.Inputs.MetricDataQueryArgs @selfRef, bool returnData = true)
    {
        @selfRef.ReturnData = returnData;
        return @selfRef;
    }

}
