// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTWireless.Inputs;

namespace Pulumi.AwsNative.IoTWireless;

public static partial class TaskDefinitionUpdateWirelessGatewayTaskCreateArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionUpdateWirelessGatewayTaskCreateArgs WithLoRaWan(this global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionUpdateWirelessGatewayTaskCreateArgs @selfRef, global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionLoRaWanUpdateGatewayTaskCreateArgs loRaWan)
    {
        @selfRef.LoRaWan = loRaWan;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionUpdateWirelessGatewayTaskCreateArgs WithLoRaWan(this global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionUpdateWirelessGatewayTaskCreateArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionLoRaWanUpdateGatewayTaskCreateArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionLoRaWanUpdateGatewayTaskCreateArgs();
        @configure(@item);
        @selfRef.LoRaWan = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionUpdateWirelessGatewayTaskCreateArgs WithUpdateDataRole(this global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionUpdateWirelessGatewayTaskCreateArgs @selfRef, global::System.String updateDataRole)
    {
        @selfRef.UpdateDataRole = updateDataRole;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionUpdateWirelessGatewayTaskCreateArgs WithUpdateDataSource(this global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionUpdateWirelessGatewayTaskCreateArgs @selfRef, global::System.String updateDataSource)
    {
        @selfRef.UpdateDataSource = updateDataSource;
        return @selfRef;
    }

}
