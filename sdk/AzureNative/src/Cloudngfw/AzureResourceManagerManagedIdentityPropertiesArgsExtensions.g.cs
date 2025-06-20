// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Cloudngfw.Inputs;

namespace Pulumi.AzureNative.Cloudngfw;

public static partial class AzureResourceManagerManagedIdentityPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.Cloudngfw.Inputs.AzureResourceManagerManagedIdentityPropertiesArgs WithType(this global::Pulumi.AzureNative.Cloudngfw.Inputs.AzureResourceManagerManagedIdentityPropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Cloudngfw.ManagedIdentityType> type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cloudngfw.Inputs.AzureResourceManagerManagedIdentityPropertiesArgs WithUserAssignedIdentities(this global::Pulumi.AzureNative.Cloudngfw.Inputs.AzureResourceManagerManagedIdentityPropertiesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.Cloudngfw.Inputs.AzureResourceManagerUserAssignedIdentityArgs> userAssignedIdentities)
    {
        @selfRef.UserAssignedIdentities = userAssignedIdentities;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cloudngfw.Inputs.AzureResourceManagerManagedIdentityPropertiesArgs WithUserAssignedIdentities(this global::Pulumi.AzureNative.Cloudngfw.Inputs.AzureResourceManagerManagedIdentityPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.Cloudngfw.Inputs.AzureResourceManagerUserAssignedIdentityArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.Cloudngfw.Inputs.AzureResourceManagerUserAssignedIdentityArgs>();
        @configure(@dict);
        @selfRef.UserAssignedIdentities = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cloudngfw.Inputs.AzureResourceManagerManagedIdentityPropertiesArgs WithUserAssignedIdentities(this global::Pulumi.AzureNative.Cloudngfw.Inputs.AzureResourceManagerManagedIdentityPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.Cloudngfw.Inputs.AzureResourceManagerUserAssignedIdentityArgs>> @create)
    {
        @selfRef.UserAssignedIdentities = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
