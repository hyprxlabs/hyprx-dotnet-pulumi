// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class ManagedServiceIdentityArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.ManagedServiceIdentityArgs WithType(this global::Pulumi.AzureNative.Network.Inputs.ManagedServiceIdentityArgs @selfRef, global::Pulumi.AzureNative.Network.ResourceIdentityType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ManagedServiceIdentityArgs WithType(this global::Pulumi.AzureNative.Network.Inputs.ManagedServiceIdentityArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.ResourceIdentityType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.Network.ResourceIdentityType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ManagedServiceIdentityArgs WithUserAssignedIdentities(this global::Pulumi.AzureNative.Network.Inputs.ManagedServiceIdentityArgs @selfRef, global::System.Collections.Generic.List<global::System.String> userAssignedIdentities)
    {
        @selfRef.UserAssignedIdentities = userAssignedIdentities;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ManagedServiceIdentityArgs WithUserAssignedIdentities(this global::Pulumi.AzureNative.Network.Inputs.ManagedServiceIdentityArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.UserAssignedIdentities = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ManagedServiceIdentityArgs WithUserAssignedIdentities(this global::Pulumi.AzureNative.Network.Inputs.ManagedServiceIdentityArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.UserAssignedIdentities = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
