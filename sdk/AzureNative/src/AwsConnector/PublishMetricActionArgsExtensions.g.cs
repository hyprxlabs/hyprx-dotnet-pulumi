// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class PublishMetricActionArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.PublishMetricActionArgs WithDimensions(this global::Pulumi.AzureNative.AwsConnector.Inputs.PublishMetricActionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.DimensionArgs> dimensions)
    {
        @selfRef.Dimensions = dimensions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.PublishMetricActionArgs WithDimensions(this global::Pulumi.AzureNative.AwsConnector.Inputs.PublishMetricActionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.DimensionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.DimensionArgs>();
        @configure(@list);
        @selfRef.Dimensions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.PublishMetricActionArgs WithDimensions(this global::Pulumi.AzureNative.AwsConnector.Inputs.PublishMetricActionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.DimensionArgs>> @create)
    {
        @selfRef.Dimensions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
