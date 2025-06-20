// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Automation.Inputs;

namespace Pulumi.AzureNative.Automation;

public static partial class IdentityArgsExtensions
{
    public static global::Pulumi.AzureNative.Automation.Inputs.IdentityArgs WithType(this global::Pulumi.AzureNative.Automation.Inputs.IdentityArgs @selfRef, global::Pulumi.AzureNative.Automation.ResourceIdentityType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.IdentityArgs WithType(this global::Pulumi.AzureNative.Automation.Inputs.IdentityArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Automation.ResourceIdentityType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.Automation.ResourceIdentityType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.IdentityArgs WithUserAssignedIdentities(this global::Pulumi.AzureNative.Automation.Inputs.IdentityArgs @selfRef, global::System.Collections.Generic.List<global::System.String> userAssignedIdentities)
    {
        @selfRef.UserAssignedIdentities = userAssignedIdentities;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.IdentityArgs WithUserAssignedIdentities(this global::Pulumi.AzureNative.Automation.Inputs.IdentityArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.UserAssignedIdentities = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.IdentityArgs WithUserAssignedIdentities(this global::Pulumi.AzureNative.Automation.Inputs.IdentityArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.UserAssignedIdentities = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
