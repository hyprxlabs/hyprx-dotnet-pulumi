// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class VirtualNetworkGatewayPolicyGroupArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupArgs WithId(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupArgs WithIsDefault(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupArgs @selfRef, bool isDefault = true)
    {
        @selfRef.IsDefault = isDefault;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupArgs WithName(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupArgs WithPolicyMembers(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupMemberArgs> policyMembers)
    {
        @selfRef.PolicyMembers = policyMembers;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupArgs WithPolicyMembers(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupMemberArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupMemberArgs>();
        @configure(@list);
        @selfRef.PolicyMembers = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupArgs WithPolicyMembers(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupMemberArgs>> @create)
    {
        @selfRef.PolicyMembers = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupArgs WithPriority(this global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkGatewayPolicyGroupArgs @selfRef, global::System.Int32 priority)
    {
        @selfRef.Priority = priority;
        return @selfRef;
    }

}
