// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Relay;

public static partial class WCFRelayArgsExtensions
{
    public static global::Pulumi.AzureNative.Relay.WCFRelayArgs WithNamespaceName(this global::Pulumi.AzureNative.Relay.WCFRelayArgs @selfRef, global::System.String namespaceName)
    {
        @selfRef.NamespaceName = namespaceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Relay.WCFRelayArgs WithRelayName(this global::Pulumi.AzureNative.Relay.WCFRelayArgs @selfRef, global::System.String relayName)
    {
        @selfRef.RelayName = relayName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Relay.WCFRelayArgs WithRelayType(this global::Pulumi.AzureNative.Relay.WCFRelayArgs @selfRef, global::Pulumi.AzureNative.Relay.Relaytype relayType)
    {
        @selfRef.RelayType = relayType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Relay.WCFRelayArgs WithRelayType(this global::Pulumi.AzureNative.Relay.WCFRelayArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Relay.Relaytype> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.Relay.Relaytype>();
        @configure(@item);
        @selfRef.RelayType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Relay.WCFRelayArgs WithRequiresClientAuthorization(this global::Pulumi.AzureNative.Relay.WCFRelayArgs @selfRef, bool requiresClientAuthorization = true)
    {
        @selfRef.RequiresClientAuthorization = requiresClientAuthorization;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Relay.WCFRelayArgs WithRequiresTransportSecurity(this global::Pulumi.AzureNative.Relay.WCFRelayArgs @selfRef, bool requiresTransportSecurity = true)
    {
        @selfRef.RequiresTransportSecurity = requiresTransportSecurity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Relay.WCFRelayArgs WithResourceGroupName(this global::Pulumi.AzureNative.Relay.WCFRelayArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Relay.WCFRelayArgs WithUserMetadata(this global::Pulumi.AzureNative.Relay.WCFRelayArgs @selfRef, global::System.String userMetadata)
    {
        @selfRef.UserMetadata = userMetadata;
        return @selfRef;
    }

}
