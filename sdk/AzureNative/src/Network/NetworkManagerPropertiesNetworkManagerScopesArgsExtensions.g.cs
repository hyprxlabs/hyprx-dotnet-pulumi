// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class NetworkManagerPropertiesNetworkManagerScopesArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.NetworkManagerPropertiesNetworkManagerScopesArgs WithManagementGroups(this global::Pulumi.AzureNative.Network.Inputs.NetworkManagerPropertiesNetworkManagerScopesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> managementGroups)
    {
        @selfRef.ManagementGroups = managementGroups;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkManagerPropertiesNetworkManagerScopesArgs WithManagementGroups(this global::Pulumi.AzureNative.Network.Inputs.NetworkManagerPropertiesNetworkManagerScopesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ManagementGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkManagerPropertiesNetworkManagerScopesArgs WithManagementGroups(this global::Pulumi.AzureNative.Network.Inputs.NetworkManagerPropertiesNetworkManagerScopesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ManagementGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkManagerPropertiesNetworkManagerScopesArgs WithSubscriptions(this global::Pulumi.AzureNative.Network.Inputs.NetworkManagerPropertiesNetworkManagerScopesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> subscriptions)
    {
        @selfRef.Subscriptions = subscriptions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkManagerPropertiesNetworkManagerScopesArgs WithSubscriptions(this global::Pulumi.AzureNative.Network.Inputs.NetworkManagerPropertiesNetworkManagerScopesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Subscriptions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkManagerPropertiesNetworkManagerScopesArgs WithSubscriptions(this global::Pulumi.AzureNative.Network.Inputs.NetworkManagerPropertiesNetworkManagerScopesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Subscriptions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
