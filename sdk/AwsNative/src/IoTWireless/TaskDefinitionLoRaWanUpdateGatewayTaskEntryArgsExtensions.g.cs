// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTWireless.Inputs;

namespace Pulumi.AwsNative.IoTWireless;

public static partial class TaskDefinitionLoRaWanUpdateGatewayTaskEntryArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionLoRaWanUpdateGatewayTaskEntryArgs WithCurrentVersion(this global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionLoRaWanUpdateGatewayTaskEntryArgs @selfRef, global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionLoRaWanGatewayVersionArgs currentVersion)
    {
        @selfRef.CurrentVersion = currentVersion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionLoRaWanUpdateGatewayTaskEntryArgs WithCurrentVersion(this global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionLoRaWanUpdateGatewayTaskEntryArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionLoRaWanGatewayVersionArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionLoRaWanGatewayVersionArgs();
        @configure(@item);
        @selfRef.CurrentVersion = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionLoRaWanUpdateGatewayTaskEntryArgs WithUpdateVersion(this global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionLoRaWanUpdateGatewayTaskEntryArgs @selfRef, global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionLoRaWanGatewayVersionArgs updateVersion)
    {
        @selfRef.UpdateVersion = updateVersion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionLoRaWanUpdateGatewayTaskEntryArgs WithUpdateVersion(this global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionLoRaWanUpdateGatewayTaskEntryArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionLoRaWanGatewayVersionArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTWireless.Inputs.TaskDefinitionLoRaWanGatewayVersionArgs();
        @configure(@item);
        @selfRef.UpdateVersion = @item;
        return @selfRef;
    }

}
