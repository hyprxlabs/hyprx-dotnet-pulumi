// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class ActionArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.ActionArgs WithParameters(this global::Pulumi.AzureNative.Network.Inputs.ActionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ParameterArgs> parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ActionArgs WithParameters(this global::Pulumi.AzureNative.Network.Inputs.ActionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ParameterArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ParameterArgs>();
        @configure(@list);
        @selfRef.Parameters = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ActionArgs WithParameters(this global::Pulumi.AzureNative.Network.Inputs.ActionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.ParameterArgs>> @create)
    {
        @selfRef.Parameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ActionArgs WithType(this global::Pulumi.AzureNative.Network.Inputs.ActionArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.RouteMapActionType> type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
