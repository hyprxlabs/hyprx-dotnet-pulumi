// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Authorization.Inputs;

namespace Pulumi.AzureNative.Authorization;

public static partial class RoleManagementPolicyRuleTargetArgsExtensions
{
    public static global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs WithCaller(this global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs @selfRef, global::System.String caller)
    {
        @selfRef.Caller = caller;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs WithEnforcedSettings(this global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs @selfRef, global::System.Collections.Generic.List<global::System.String> enforcedSettings)
    {
        @selfRef.EnforcedSettings = enforcedSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs WithEnforcedSettings(this global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.EnforcedSettings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs WithEnforcedSettings(this global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.EnforcedSettings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs WithInheritableSettings(this global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs @selfRef, global::System.Collections.Generic.List<global::System.String> inheritableSettings)
    {
        @selfRef.InheritableSettings = inheritableSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs WithInheritableSettings(this global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.InheritableSettings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs WithInheritableSettings(this global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.InheritableSettings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs WithLevel(this global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs @selfRef, global::System.String level)
    {
        @selfRef.Level = level;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs WithOperations(this global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs @selfRef, global::System.Collections.Generic.List<global::System.String> operations)
    {
        @selfRef.Operations = operations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs WithOperations(this global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Operations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs WithOperations(this global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Operations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs WithTargetObjects(this global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs @selfRef, global::System.Collections.Generic.List<global::System.String> targetObjects)
    {
        @selfRef.TargetObjects = targetObjects;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs WithTargetObjects(this global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.TargetObjects = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs WithTargetObjects(this global::Pulumi.AzureNative.Authorization.Inputs.RoleManagementPolicyRuleTargetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.TargetObjects = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
