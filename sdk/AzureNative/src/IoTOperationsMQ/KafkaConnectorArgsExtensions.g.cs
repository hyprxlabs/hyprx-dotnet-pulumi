// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.IoTOperationsMQ;

public static partial class KafkaConnectorArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithClientIdPrefix(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::System.String clientIdPrefix)
    {
        @selfRef.ClientIdPrefix = clientIdPrefix;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithExtendedLocation(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.ExtendedLocationPropertyArgs extendedLocation)
    {
        @selfRef.ExtendedLocation = extendedLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithExtendedLocation(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.ExtendedLocationPropertyArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.ExtendedLocationPropertyArgs();
        @configure(@item);
        @selfRef.ExtendedLocation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithImage(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.ContainerImageArgs image)
    {
        @selfRef.Image = image;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithImage(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.ContainerImageArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.ContainerImageArgs();
        @configure(@item);
        @selfRef.Image = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithInstances(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::System.Int32 instances)
    {
        @selfRef.Instances = instances;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithKafkaConnection(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KafkaRemoteBrokerConnectionSpecArgs kafkaConnection)
    {
        @selfRef.KafkaConnection = kafkaConnection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithKafkaConnection(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KafkaRemoteBrokerConnectionSpecArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KafkaRemoteBrokerConnectionSpecArgs();
        @configure(@item);
        @selfRef.KafkaConnection = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithKafkaConnectorName(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::System.String kafkaConnectorName)
    {
        @selfRef.KafkaConnectorName = kafkaConnectorName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithLocalBrokerConnection(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.LocalBrokerConnectionSpecArgs localBrokerConnection)
    {
        @selfRef.LocalBrokerConnection = localBrokerConnection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithLocalBrokerConnection(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.LocalBrokerConnectionSpecArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.LocalBrokerConnectionSpecArgs();
        @configure(@item);
        @selfRef.LocalBrokerConnection = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithLocation(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithLogLevel(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::System.String logLevel)
    {
        @selfRef.LogLevel = logLevel;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithMqName(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::System.String mqName)
    {
        @selfRef.MqName = mqName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithNodeTolerations(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.NodeTolerationsArgs nodeTolerations)
    {
        @selfRef.NodeTolerations = nodeTolerations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithNodeTolerations(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.NodeTolerationsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.NodeTolerationsArgs();
        @configure(@item);
        @selfRef.NodeTolerations = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithResourceGroupName(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithTags(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithTags(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs WithTags(this global::Pulumi.AzureNative.IoTOperationsMQ.KafkaConnectorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
