// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.IoTOperationsMQ;

public static partial class BrokerListenerArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs WithAuthenticationEnabled(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs @selfRef, bool authenticationEnabled = true)
    {
        @selfRef.AuthenticationEnabled = authenticationEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs WithAuthorizationEnabled(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs @selfRef, bool authorizationEnabled = true)
    {
        @selfRef.AuthorizationEnabled = authorizationEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs WithBrokerName(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs @selfRef, global::System.String brokerName)
    {
        @selfRef.BrokerName = brokerName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs WithBrokerRef(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs @selfRef, global::System.String brokerRef)
    {
        @selfRef.BrokerRef = brokerRef;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs WithExtendedLocation(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.ExtendedLocationPropertyArgs extendedLocation)
    {
        @selfRef.ExtendedLocation = extendedLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs WithExtendedLocation(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.ExtendedLocationPropertyArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.ExtendedLocationPropertyArgs();
        @configure(@item);
        @selfRef.ExtendedLocation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs WithListenerName(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs @selfRef, global::System.String listenerName)
    {
        @selfRef.ListenerName = listenerName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs WithLocation(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs WithMqName(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs @selfRef, global::System.String mqName)
    {
        @selfRef.MqName = mqName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs WithNodePort(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs @selfRef, global::System.Int32 nodePort)
    {
        @selfRef.NodePort = nodePort;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs WithPort(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs @selfRef, global::System.Int32 port)
    {
        @selfRef.Port = port;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs WithResourceGroupName(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs WithServiceName(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs @selfRef, global::System.String serviceName)
    {
        @selfRef.ServiceName = serviceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs WithServiceType(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.IoTOperationsMQ.ServiceType> serviceType)
    {
        @selfRef.ServiceType = serviceType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs WithTags(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs WithTags(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs WithTags(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs WithTls(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.TlsCertMethodArgs tls)
    {
        @selfRef.Tls = tls;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs WithTls(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerListenerArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.TlsCertMethodArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.TlsCertMethodArgs();
        @configure(@item);
        @selfRef.Tls = @item;
        return @selfRef;
    }

}
