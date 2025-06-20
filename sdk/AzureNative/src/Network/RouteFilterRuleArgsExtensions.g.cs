// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class RouteFilterRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.RouteFilterRuleArgs WithAccess(this global::Pulumi.AzureNative.Network.Inputs.RouteFilterRuleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.Access> access)
    {
        @selfRef.Access = access;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.RouteFilterRuleArgs WithCommunities(this global::Pulumi.AzureNative.Network.Inputs.RouteFilterRuleArgs @selfRef, global::System.Collections.Generic.List<global::System.String> communities)
    {
        @selfRef.Communities = communities;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.RouteFilterRuleArgs WithCommunities(this global::Pulumi.AzureNative.Network.Inputs.RouteFilterRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Communities = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.RouteFilterRuleArgs WithCommunities(this global::Pulumi.AzureNative.Network.Inputs.RouteFilterRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Communities = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.RouteFilterRuleArgs WithId(this global::Pulumi.AzureNative.Network.Inputs.RouteFilterRuleArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.RouteFilterRuleArgs WithLocation(this global::Pulumi.AzureNative.Network.Inputs.RouteFilterRuleArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.RouteFilterRuleArgs WithName(this global::Pulumi.AzureNative.Network.Inputs.RouteFilterRuleArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.RouteFilterRuleArgs WithRouteFilterRuleType(this global::Pulumi.AzureNative.Network.Inputs.RouteFilterRuleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.RouteFilterRuleType> routeFilterRuleType)
    {
        @selfRef.RouteFilterRuleType = routeFilterRuleType;
        return @selfRef;
    }

}
