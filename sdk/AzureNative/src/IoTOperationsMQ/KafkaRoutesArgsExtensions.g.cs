// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.IoTOperationsMQ.Inputs;

namespace Pulumi.AzureNative.IoTOperationsMQ;

public static partial class KafkaRoutesArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KafkaRoutesArgs WithKafkaToMqtt(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KafkaRoutesArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KafkaToMqttRoutesArgs kafkaToMqtt)
    {
        @selfRef.KafkaToMqtt = kafkaToMqtt;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KafkaRoutesArgs WithKafkaToMqtt(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KafkaRoutesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KafkaToMqttRoutesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KafkaToMqttRoutesArgs();
        @configure(@item);
        @selfRef.KafkaToMqtt = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KafkaRoutesArgs WithMqttToKafka(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KafkaRoutesArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttToKafkaRoutesArgs mqttToKafka)
    {
        @selfRef.MqttToKafka = mqttToKafka;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KafkaRoutesArgs WithMqttToKafka(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KafkaRoutesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttToKafkaRoutesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttToKafkaRoutesArgs();
        @configure(@item);
        @selfRef.MqttToKafka = @item;
        return @selfRef;
    }

}
