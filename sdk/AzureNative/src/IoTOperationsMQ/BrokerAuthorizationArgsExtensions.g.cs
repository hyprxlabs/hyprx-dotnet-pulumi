// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.IoTOperationsMQ;

public static partial class BrokerAuthorizationArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs WithAuthorizationName(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs @selfRef, global::System.String authorizationName)
    {
        @selfRef.AuthorizationName = authorizationName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs WithAuthorizationPolicies(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.AuthorizationConfigArgs authorizationPolicies)
    {
        @selfRef.AuthorizationPolicies = authorizationPolicies;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs WithAuthorizationPolicies(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.AuthorizationConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.AuthorizationConfigArgs();
        @configure(@item);
        @selfRef.AuthorizationPolicies = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs WithBrokerName(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs @selfRef, global::System.String brokerName)
    {
        @selfRef.BrokerName = brokerName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs WithExtendedLocation(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.ExtendedLocationPropertyArgs extendedLocation)
    {
        @selfRef.ExtendedLocation = extendedLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs WithExtendedLocation(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.ExtendedLocationPropertyArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.ExtendedLocationPropertyArgs();
        @configure(@item);
        @selfRef.ExtendedLocation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs WithListenerRef(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs @selfRef, global::System.Collections.Generic.List<global::System.String> listenerRef)
    {
        @selfRef.ListenerRef = listenerRef;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs WithListenerRef(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ListenerRef = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs WithListenerRef(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ListenerRef = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs WithLocation(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs WithMqName(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs @selfRef, global::System.String mqName)
    {
        @selfRef.MqName = mqName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs WithResourceGroupName(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs WithTags(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs WithTags(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs WithTags(this global::Pulumi.AzureNative.IoTOperationsMQ.BrokerAuthorizationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
