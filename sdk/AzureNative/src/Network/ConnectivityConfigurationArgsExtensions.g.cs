// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Network;

public static partial class ConnectivityConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs WithAppliesToGroups(this global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ConnectivityGroupItemArgs> appliesToGroups)
    {
        @selfRef.AppliesToGroups = appliesToGroups;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs WithAppliesToGroups(this global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ConnectivityGroupItemArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ConnectivityGroupItemArgs>();
        @configure(@list);
        @selfRef.AppliesToGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs WithAppliesToGroups(this global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.ConnectivityGroupItemArgs>> @create)
    {
        @selfRef.AppliesToGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs WithConfigurationName(this global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs @selfRef, global::System.String configurationName)
    {
        @selfRef.ConfigurationName = configurationName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs WithConnectivityTopology(this global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.ConnectivityTopology> connectivityTopology)
    {
        @selfRef.ConnectivityTopology = connectivityTopology;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs WithDeleteExistingPeering(this global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.DeleteExistingPeering> deleteExistingPeering)
    {
        @selfRef.DeleteExistingPeering = deleteExistingPeering;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs WithDescription(this global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs WithHubs(this global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.HubArgs> hubs)
    {
        @selfRef.Hubs = hubs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs WithHubs(this global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.HubArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.HubArgs>();
        @configure(@list);
        @selfRef.Hubs = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs WithHubs(this global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.HubArgs>> @create)
    {
        @selfRef.Hubs = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs WithIsGlobal(this global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.IsGlobal> isGlobal)
    {
        @selfRef.IsGlobal = isGlobal;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs WithNetworkManagerName(this global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs @selfRef, global::System.String networkManagerName)
    {
        @selfRef.NetworkManagerName = networkManagerName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs WithResourceGroupName(this global::Pulumi.AzureNative.Network.ConnectivityConfigurationArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
