// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.IoTOperationsMQ.Inputs;

namespace Pulumi.AzureNative.IoTOperationsMQ;

public static partial class LocalBrokerAuthenticationMethodsArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.LocalBrokerAuthenticationMethodsArgs WithKubernetes(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.LocalBrokerAuthenticationMethodsArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.LocalBrokerKubernetesAuthenticationArgs kubernetes)
    {
        @selfRef.Kubernetes = kubernetes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.LocalBrokerAuthenticationMethodsArgs WithKubernetes(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.LocalBrokerAuthenticationMethodsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.LocalBrokerKubernetesAuthenticationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.LocalBrokerKubernetesAuthenticationArgs();
        @configure(@item);
        @selfRef.Kubernetes = @item;
        return @selfRef;
    }

}
