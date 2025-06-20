// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.IoTOperations.Inputs;

namespace Pulumi.AzureNative.IoTOperations;

public static partial class ClientConfigArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTOperations.Inputs.ClientConfigArgs WithMaxKeepAliveSeconds(this global::Pulumi.AzureNative.IoTOperations.Inputs.ClientConfigArgs @selfRef, global::System.Int32 maxKeepAliveSeconds)
    {
        @selfRef.MaxKeepAliveSeconds = maxKeepAliveSeconds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperations.Inputs.ClientConfigArgs WithMaxMessageExpirySeconds(this global::Pulumi.AzureNative.IoTOperations.Inputs.ClientConfigArgs @selfRef, global::System.Int32 maxMessageExpirySeconds)
    {
        @selfRef.MaxMessageExpirySeconds = maxMessageExpirySeconds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperations.Inputs.ClientConfigArgs WithMaxPacketSizeBytes(this global::Pulumi.AzureNative.IoTOperations.Inputs.ClientConfigArgs @selfRef, global::System.Int32 maxPacketSizeBytes)
    {
        @selfRef.MaxPacketSizeBytes = maxPacketSizeBytes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperations.Inputs.ClientConfigArgs WithMaxReceiveMaximum(this global::Pulumi.AzureNative.IoTOperations.Inputs.ClientConfigArgs @selfRef, global::System.Int32 maxReceiveMaximum)
    {
        @selfRef.MaxReceiveMaximum = maxReceiveMaximum;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperations.Inputs.ClientConfigArgs WithMaxSessionExpirySeconds(this global::Pulumi.AzureNative.IoTOperations.Inputs.ClientConfigArgs @selfRef, global::System.Int32 maxSessionExpirySeconds)
    {
        @selfRef.MaxSessionExpirySeconds = maxSessionExpirySeconds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperations.Inputs.ClientConfigArgs WithSubscriberQueueLimit(this global::Pulumi.AzureNative.IoTOperations.Inputs.ClientConfigArgs @selfRef, global::Pulumi.AzureNative.IoTOperations.Inputs.SubscriberQueueLimitArgs subscriberQueueLimit)
    {
        @selfRef.SubscriberQueueLimit = subscriberQueueLimit;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperations.Inputs.ClientConfigArgs WithSubscriberQueueLimit(this global::Pulumi.AzureNative.IoTOperations.Inputs.ClientConfigArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperations.Inputs.SubscriberQueueLimitArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperations.Inputs.SubscriberQueueLimitArgs();
        @configure(@item);
        @selfRef.SubscriberQueueLimit = @item;
        return @selfRef;
    }

}
