// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.IoTOperationsMQ.Inputs;

namespace Pulumi.AzureNative.IoTOperationsMQ;

public static partial class MqttBridgeRemoteBrokerAuthenticationMethodsArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttBridgeRemoteBrokerAuthenticationMethodsArgs WithSystemAssignedManagedIdentity(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttBridgeRemoteBrokerAuthenticationMethodsArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.ManagedIdentityAuthenticationArgs systemAssignedManagedIdentity)
    {
        @selfRef.SystemAssignedManagedIdentity = systemAssignedManagedIdentity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttBridgeRemoteBrokerAuthenticationMethodsArgs WithSystemAssignedManagedIdentity(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttBridgeRemoteBrokerAuthenticationMethodsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.ManagedIdentityAuthenticationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.ManagedIdentityAuthenticationArgs();
        @configure(@item);
        @selfRef.SystemAssignedManagedIdentity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttBridgeRemoteBrokerAuthenticationMethodsArgs WithX509(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttBridgeRemoteBrokerAuthenticationMethodsArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttBridgeRemoteBrokerX509AuthenticationArgs x509)
    {
        @selfRef.X509 = x509;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttBridgeRemoteBrokerAuthenticationMethodsArgs WithX509(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttBridgeRemoteBrokerAuthenticationMethodsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttBridgeRemoteBrokerX509AuthenticationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.MqttBridgeRemoteBrokerX509AuthenticationArgs();
        @configure(@item);
        @selfRef.X509 = @item;
        return @selfRef;
    }

}
