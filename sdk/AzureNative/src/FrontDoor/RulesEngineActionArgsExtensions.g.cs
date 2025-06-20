// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.FrontDoor.Inputs;

namespace Pulumi.AzureNative.FrontDoor;

public static partial class RulesEngineActionArgsExtensions
{
    public static global::Pulumi.AzureNative.FrontDoor.Inputs.RulesEngineActionArgs WithRequestHeaderActions(this global::Pulumi.AzureNative.FrontDoor.Inputs.RulesEngineActionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.HeaderActionArgs> requestHeaderActions)
    {
        @selfRef.RequestHeaderActions = requestHeaderActions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.RulesEngineActionArgs WithRequestHeaderActions(this global::Pulumi.AzureNative.FrontDoor.Inputs.RulesEngineActionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.HeaderActionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.HeaderActionArgs>();
        @configure(@list);
        @selfRef.RequestHeaderActions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.RulesEngineActionArgs WithRequestHeaderActions(this global::Pulumi.AzureNative.FrontDoor.Inputs.RulesEngineActionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.FrontDoor.Inputs.HeaderActionArgs>> @create)
    {
        @selfRef.RequestHeaderActions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.RulesEngineActionArgs WithResponseHeaderActions(this global::Pulumi.AzureNative.FrontDoor.Inputs.RulesEngineActionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.HeaderActionArgs> responseHeaderActions)
    {
        @selfRef.ResponseHeaderActions = responseHeaderActions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.RulesEngineActionArgs WithResponseHeaderActions(this global::Pulumi.AzureNative.FrontDoor.Inputs.RulesEngineActionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.HeaderActionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.HeaderActionArgs>();
        @configure(@list);
        @selfRef.ResponseHeaderActions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.RulesEngineActionArgs WithResponseHeaderActions(this global::Pulumi.AzureNative.FrontDoor.Inputs.RulesEngineActionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.FrontDoor.Inputs.HeaderActionArgs>> @create)
    {
        @selfRef.ResponseHeaderActions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.RulesEngineActionArgs WithRouteConfigurationOverride(this global::Pulumi.AzureNative.FrontDoor.Inputs.RulesEngineActionArgs @selfRef, global::Pulumi.Union<global::Pulumi.AzureNative.FrontDoor.Inputs.ForwardingConfigurationArgs, global::Pulumi.AzureNative.FrontDoor.Inputs.RedirectConfigurationArgs> routeConfigurationOverride)
    {
        @selfRef.RouteConfigurationOverride = routeConfigurationOverride;
        return @selfRef;
    }

}
