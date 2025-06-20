// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.App.Inputs;

namespace Pulumi.AzureNative.App;

public static partial class HttpRouteRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.App.Inputs.HttpRouteRuleArgs WithDescription(this global::Pulumi.AzureNative.App.Inputs.HttpRouteRuleArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.HttpRouteRuleArgs WithRoutes(this global::Pulumi.AzureNative.App.Inputs.HttpRouteRuleArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.HttpRouteArgs> routes)
    {
        @selfRef.Routes = routes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.HttpRouteRuleArgs WithRoutes(this global::Pulumi.AzureNative.App.Inputs.HttpRouteRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.HttpRouteArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.HttpRouteArgs>();
        @configure(@list);
        @selfRef.Routes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.HttpRouteRuleArgs WithRoutes(this global::Pulumi.AzureNative.App.Inputs.HttpRouteRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.App.Inputs.HttpRouteArgs>> @create)
    {
        @selfRef.Routes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.HttpRouteRuleArgs WithTargets(this global::Pulumi.AzureNative.App.Inputs.HttpRouteRuleArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.HttpRouteTargetArgs> targets)
    {
        @selfRef.Targets = targets;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.HttpRouteRuleArgs WithTargets(this global::Pulumi.AzureNative.App.Inputs.HttpRouteRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.HttpRouteTargetArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.HttpRouteTargetArgs>();
        @configure(@list);
        @selfRef.Targets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.HttpRouteRuleArgs WithTargets(this global::Pulumi.AzureNative.App.Inputs.HttpRouteRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.App.Inputs.HttpRouteTargetArgs>> @create)
    {
        @selfRef.Targets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
