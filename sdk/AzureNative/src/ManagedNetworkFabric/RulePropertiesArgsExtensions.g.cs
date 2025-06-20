// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ManagedNetworkFabric.Inputs;

namespace Pulumi.AzureNative.ManagedNetworkFabric;

public static partial class RulePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.RulePropertiesArgs WithAction(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.RulePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ManagedNetworkFabric.Action> action)
    {
        @selfRef.Action = action;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.RulePropertiesArgs WithAddressList(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.RulePropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> addressList)
    {
        @selfRef.AddressList = addressList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.RulePropertiesArgs WithAddressList(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.RulePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AddressList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.RulePropertiesArgs WithAddressList(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.RulePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AddressList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
