// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Compute.Inputs;

namespace Pulumi.AzureNative.Compute;

public static partial class AccessControlRulesRoleAssignmentArgsExtensions
{
    public static global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesRoleAssignmentArgs WithIdentities(this global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesRoleAssignmentArgs @selfRef, global::System.Collections.Generic.List<global::System.String> identities)
    {
        @selfRef.Identities = identities;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesRoleAssignmentArgs WithIdentities(this global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesRoleAssignmentArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Identities = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesRoleAssignmentArgs WithIdentities(this global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesRoleAssignmentArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Identities = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesRoleAssignmentArgs WithRole(this global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesRoleAssignmentArgs @selfRef, global::System.String role)
    {
        @selfRef.Role = role;
        return @selfRef;
    }

}
