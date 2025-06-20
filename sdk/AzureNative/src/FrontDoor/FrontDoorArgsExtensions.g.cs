// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.FrontDoor;

public static partial class FrontDoorArgsExtensions
{
    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithBackendPools(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs> backendPools)
    {
        @selfRef.BackendPools = backendPools;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithBackendPools(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs>();
        @configure(@list);
        @selfRef.BackendPools = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithBackendPools(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolArgs>> @create)
    {
        @selfRef.BackendPools = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithBackendPoolsSettings(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolsSettingsArgs backendPoolsSettings)
    {
        @selfRef.BackendPoolsSettings = backendPoolsSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithBackendPoolsSettings(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolsSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.FrontDoor.Inputs.BackendPoolsSettingsArgs();
        @configure(@item);
        @selfRef.BackendPoolsSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithEnabledState(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.FrontDoor.FrontDoorEnabledState> enabledState)
    {
        @selfRef.EnabledState = enabledState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithFriendlyName(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.String friendlyName)
    {
        @selfRef.FriendlyName = friendlyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithFrontDoorName(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.String frontDoorName)
    {
        @selfRef.FrontDoorName = frontDoorName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithFrontendEndpoints(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.FrontendEndpointArgs> frontendEndpoints)
    {
        @selfRef.FrontendEndpoints = frontendEndpoints;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithFrontendEndpoints(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.FrontendEndpointArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.FrontendEndpointArgs>();
        @configure(@list);
        @selfRef.FrontendEndpoints = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithFrontendEndpoints(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.FrontDoor.Inputs.FrontendEndpointArgs>> @create)
    {
        @selfRef.FrontendEndpoints = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithHealthProbeSettings(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.HealthProbeSettingsModelArgs> healthProbeSettings)
    {
        @selfRef.HealthProbeSettings = healthProbeSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithHealthProbeSettings(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.HealthProbeSettingsModelArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.HealthProbeSettingsModelArgs>();
        @configure(@list);
        @selfRef.HealthProbeSettings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithHealthProbeSettings(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.FrontDoor.Inputs.HealthProbeSettingsModelArgs>> @create)
    {
        @selfRef.HealthProbeSettings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithLoadBalancingSettings(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.LoadBalancingSettingsModelArgs> loadBalancingSettings)
    {
        @selfRef.LoadBalancingSettings = loadBalancingSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithLoadBalancingSettings(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.LoadBalancingSettingsModelArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.LoadBalancingSettingsModelArgs>();
        @configure(@list);
        @selfRef.LoadBalancingSettings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithLoadBalancingSettings(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.FrontDoor.Inputs.LoadBalancingSettingsModelArgs>> @create)
    {
        @selfRef.LoadBalancingSettings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithLocation(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithResourceGroupName(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithRoutingRules(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.RoutingRuleArgs> routingRules)
    {
        @selfRef.RoutingRules = routingRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithRoutingRules(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.RoutingRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.RoutingRuleArgs>();
        @configure(@list);
        @selfRef.RoutingRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithRoutingRules(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.FrontDoor.Inputs.RoutingRuleArgs>> @create)
    {
        @selfRef.RoutingRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithTags(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithTags(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs WithTags(this global::Pulumi.AzureNative.FrontDoor.FrontDoorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
