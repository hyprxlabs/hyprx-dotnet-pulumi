// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Blueprint;

public static partial class RoleAssignmentArtifactArgsExtensions
{
    public static global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs WithArtifactName(this global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs @selfRef, global::System.String artifactName)
    {
        @selfRef.ArtifactName = artifactName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs WithBlueprintName(this global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs @selfRef, global::System.String blueprintName)
    {
        @selfRef.BlueprintName = blueprintName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs WithDependsOn(this global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs @selfRef, global::System.Collections.Generic.List<global::System.String> dependsOn)
    {
        @selfRef.DependsOn = dependsOn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs WithDependsOn(this global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.DependsOn = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs WithDependsOn(this global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.DependsOn = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs WithDescription(this global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs WithDisplayName(this global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs @selfRef, global::System.String displayName)
    {
        @selfRef.DisplayName = displayName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs WithKind(this global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs @selfRef, global::System.String kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs WithPrincipalIds(this global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs @selfRef, global::System.Object principalIds)
    {
        @selfRef.PrincipalIds = principalIds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs WithPrincipalIds(this global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.PrincipalIds = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs WithResourceGroup(this global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs @selfRef, global::System.String resourceGroup)
    {
        @selfRef.ResourceGroup = resourceGroup;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs WithResourceScope(this global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs @selfRef, global::System.String resourceScope)
    {
        @selfRef.ResourceScope = resourceScope;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs WithRoleDefinitionId(this global::Pulumi.AzureNative.Blueprint.RoleAssignmentArtifactArgs @selfRef, global::System.String roleDefinitionId)
    {
        @selfRef.RoleDefinitionId = roleDefinitionId;
        return @selfRef;
    }

}
