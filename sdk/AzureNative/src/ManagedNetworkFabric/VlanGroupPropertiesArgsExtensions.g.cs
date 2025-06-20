// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ManagedNetworkFabric.Inputs;

namespace Pulumi.AzureNative.ManagedNetworkFabric;

public static partial class VlanGroupPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VlanGroupPropertiesArgs WithName(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VlanGroupPropertiesArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VlanGroupPropertiesArgs WithVlans(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VlanGroupPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> vlans)
    {
        @selfRef.Vlans = vlans;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VlanGroupPropertiesArgs WithVlans(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VlanGroupPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Vlans = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VlanGroupPropertiesArgs WithVlans(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VlanGroupPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Vlans = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
