// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ServiceFabric.Inputs;

namespace Pulumi.AzureNative.ServiceFabric;

public static partial class ManagedIdentityArgsExtensions
{
    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.ManagedIdentityArgs WithType(this global::Pulumi.AzureNative.ServiceFabric.Inputs.ManagedIdentityArgs @selfRef, global::Pulumi.AzureNative.ServiceFabric.ManagedIdentityType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.ManagedIdentityArgs WithType(this global::Pulumi.AzureNative.ServiceFabric.Inputs.ManagedIdentityArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ServiceFabric.ManagedIdentityType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.ServiceFabric.ManagedIdentityType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.ManagedIdentityArgs WithUserAssignedIdentities(this global::Pulumi.AzureNative.ServiceFabric.Inputs.ManagedIdentityArgs @selfRef, global::System.Collections.Generic.List<global::System.String> userAssignedIdentities)
    {
        @selfRef.UserAssignedIdentities = userAssignedIdentities;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.ManagedIdentityArgs WithUserAssignedIdentities(this global::Pulumi.AzureNative.ServiceFabric.Inputs.ManagedIdentityArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.UserAssignedIdentities = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.ManagedIdentityArgs WithUserAssignedIdentities(this global::Pulumi.AzureNative.ServiceFabric.Inputs.ManagedIdentityArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.UserAssignedIdentities = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
