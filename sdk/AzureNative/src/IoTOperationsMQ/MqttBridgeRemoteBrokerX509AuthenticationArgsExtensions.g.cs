// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.IoTOperationsMQ.Inputs;

namespace Pulumi.AzureNative.IoTOperationsMQ;

public static partial class MqttBridgeRemoteBrokerX509AuthenticationArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttBridgeRemoteBrokerX509AuthenticationArgs WithKeyVault(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttBridgeRemoteBrokerX509AuthenticationArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KeyVaultCertificatePropertiesArgs keyVault)
    {
        @selfRef.KeyVault = keyVault;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttBridgeRemoteBrokerX509AuthenticationArgs WithKeyVault(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttBridgeRemoteBrokerX509AuthenticationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KeyVaultCertificatePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KeyVaultCertificatePropertiesArgs();
        @configure(@item);
        @selfRef.KeyVault = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttBridgeRemoteBrokerX509AuthenticationArgs WithSecretName(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttBridgeRemoteBrokerX509AuthenticationArgs @selfRef, global::System.String secretName)
    {
        @selfRef.SecretName = secretName;
        return @selfRef;
    }

}
