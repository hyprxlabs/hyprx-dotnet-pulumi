// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.KafkaConnect.Inputs;

namespace Pulumi.AwsNative.KafkaConnect;

public static partial class ConnectorKafkaClusterClientAuthenticationArgsExtensions
{
    public static global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorKafkaClusterClientAuthenticationArgs WithAuthenticationType(this global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorKafkaClusterClientAuthenticationArgs @selfRef, global::Pulumi.AwsNative.KafkaConnect.ConnectorKafkaClusterClientAuthenticationType authenticationType)
    {
        @selfRef.AuthenticationType = authenticationType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorKafkaClusterClientAuthenticationArgs WithAuthenticationType(this global::Pulumi.AwsNative.KafkaConnect.Inputs.ConnectorKafkaClusterClientAuthenticationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.KafkaConnect.ConnectorKafkaClusterClientAuthenticationType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.KafkaConnect.ConnectorKafkaClusterClientAuthenticationType>();
        @configure(@item);
        @selfRef.AuthenticationType = @item;
        return @selfRef;
    }

}
