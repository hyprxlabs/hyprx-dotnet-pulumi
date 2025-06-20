// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DigitalTwins.Inputs;

namespace Pulumi.AzureNative.DigitalTwins;

public static partial class ServiceBusArgsExtensions
{
    public static global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs WithAuthenticationType(this global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DigitalTwins.AuthenticationType> authenticationType)
    {
        @selfRef.AuthenticationType = authenticationType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs WithDeadLetterSecret(this global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs @selfRef, global::System.String deadLetterSecret)
    {
        @selfRef.DeadLetterSecret = deadLetterSecret;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs WithDeadLetterUri(this global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs @selfRef, global::System.String deadLetterUri)
    {
        @selfRef.DeadLetterUri = deadLetterUri;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs WithEndpointType(this global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs @selfRef, global::System.String endpointType)
    {
        @selfRef.EndpointType = endpointType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs WithEndpointUri(this global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs @selfRef, global::System.String endpointUri)
    {
        @selfRef.EndpointUri = endpointUri;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs WithEntityPath(this global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs @selfRef, global::System.String entityPath)
    {
        @selfRef.EntityPath = entityPath;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs WithIdentity(this global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs @selfRef, global::Pulumi.AzureNative.DigitalTwins.Inputs.ManagedIdentityReferenceArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs WithIdentity(this global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DigitalTwins.Inputs.ManagedIdentityReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DigitalTwins.Inputs.ManagedIdentityReferenceArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs WithPrimaryConnectionString(this global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs @selfRef, global::System.String primaryConnectionString)
    {
        @selfRef.PrimaryConnectionString = primaryConnectionString;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs WithSecondaryConnectionString(this global::Pulumi.AzureNative.DigitalTwins.Inputs.ServiceBusArgs @selfRef, global::System.String secondaryConnectionString)
    {
        @selfRef.SecondaryConnectionString = secondaryConnectionString;
        return @selfRef;
    }

}
