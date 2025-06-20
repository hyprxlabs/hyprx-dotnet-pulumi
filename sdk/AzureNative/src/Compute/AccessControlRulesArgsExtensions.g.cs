// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Compute.Inputs;

namespace Pulumi.AzureNative.Compute;

public static partial class AccessControlRulesArgsExtensions
{
    public static global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs WithIdentities(this global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesIdentityArgs> identities)
    {
        @selfRef.Identities = identities;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs WithIdentities(this global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesIdentityArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesIdentityArgs>();
        @configure(@list);
        @selfRef.Identities = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs WithIdentities(this global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesIdentityArgs>> @create)
    {
        @selfRef.Identities = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs WithPrivileges(this global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesPrivilegeArgs> privileges)
    {
        @selfRef.Privileges = privileges;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs WithPrivileges(this global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesPrivilegeArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesPrivilegeArgs>();
        @configure(@list);
        @selfRef.Privileges = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs WithPrivileges(this global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesPrivilegeArgs>> @create)
    {
        @selfRef.Privileges = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs WithRoleAssignments(this global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesRoleAssignmentArgs> roleAssignments)
    {
        @selfRef.RoleAssignments = roleAssignments;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs WithRoleAssignments(this global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesRoleAssignmentArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesRoleAssignmentArgs>();
        @configure(@list);
        @selfRef.RoleAssignments = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs WithRoleAssignments(this global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesRoleAssignmentArgs>> @create)
    {
        @selfRef.RoleAssignments = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs WithRoles(this global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesRoleArgs> roles)
    {
        @selfRef.Roles = roles;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs WithRoles(this global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesRoleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesRoleArgs>();
        @configure(@list);
        @selfRef.Roles = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs WithRoles(this global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Compute.Inputs.AccessControlRulesRoleArgs>> @create)
    {
        @selfRef.Roles = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
