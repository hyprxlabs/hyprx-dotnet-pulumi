// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class MetricsArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MetricsArgs WithEventThreshold(this global::Pulumi.AzureNative.AwsConnector.Inputs.MetricsArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationTimeValueArgs eventThreshold)
    {
        @selfRef.EventThreshold = eventThreshold;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MetricsArgs WithEventThreshold(this global::Pulumi.AzureNative.AwsConnector.Inputs.MetricsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationTimeValueArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationTimeValueArgs();
        @configure(@item);
        @selfRef.EventThreshold = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.MetricsArgs WithStatus(this global::Pulumi.AzureNative.AwsConnector.Inputs.MetricsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AwsConnector.MetricsStatus> status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

}
