// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.KafkaConnect.Inputs;

namespace Pulumi.AwsNative.KafkaConnect;

public static partial class ConnectorKafkaClusterArgsExtensions
{
    public static global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorKafkaClusterArgs WithApacheKafkaCluster(this global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorKafkaClusterArgs @selfRef, global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorApacheKafkaClusterArgs apacheKafkaCluster)
    {
        @selfRef.ApacheKafkaCluster = apacheKafkaCluster;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorKafkaClusterArgs WithApacheKafkaCluster(this global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorKafkaClusterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorApacheKafkaClusterArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorApacheKafkaClusterArgs();
        @configure(@item);
        @selfRef.ApacheKafkaCluster = @item;
        return @selfRef;
    }

}
