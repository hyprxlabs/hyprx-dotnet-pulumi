// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Chaos.Inputs;

namespace Pulumi.AzureNative.Chaos;

public static partial class DiscreteActionArgsExtensions
{
    public static global::Pulumi.AzureNative.Chaos.Inputs.DiscreteActionArgs WithName(this global::Pulumi.AzureNative.Chaos.Inputs.DiscreteActionArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Chaos.Inputs.DiscreteActionArgs WithParameters(this global::Pulumi.AzureNative.Chaos.Inputs.DiscreteActionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Chaos.Inputs.KeyValuePairArgs> parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Chaos.Inputs.DiscreteActionArgs WithParameters(this global::Pulumi.AzureNative.Chaos.Inputs.DiscreteActionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Chaos.Inputs.KeyValuePairArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Chaos.Inputs.KeyValuePairArgs>();
        @configure(@list);
        @selfRef.Parameters = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Chaos.Inputs.DiscreteActionArgs WithParameters(this global::Pulumi.AzureNative.Chaos.Inputs.DiscreteActionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Chaos.Inputs.KeyValuePairArgs>> @create)
    {
        @selfRef.Parameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Chaos.Inputs.DiscreteActionArgs WithSelectorId(this global::Pulumi.AzureNative.Chaos.Inputs.DiscreteActionArgs @selfRef, global::System.String selectorId)
    {
        @selfRef.SelectorId = selectorId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Chaos.Inputs.DiscreteActionArgs WithType(this global::Pulumi.AzureNative.Chaos.Inputs.DiscreteActionArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
