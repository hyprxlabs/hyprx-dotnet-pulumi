// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.SecurityInsights;

public static partial class IncidentRelationArgsExtensions
{
    public static global::Pulumi.AzureNative.SecurityInsights.IncidentRelationArgs WithIncidentId(this global::Pulumi.AzureNative.SecurityInsights.IncidentRelationArgs @selfRef, global::System.String incidentId)
    {
        @selfRef.IncidentId = incidentId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.IncidentRelationArgs WithRelatedResourceId(this global::Pulumi.AzureNative.SecurityInsights.IncidentRelationArgs @selfRef, global::System.String relatedResourceId)
    {
        @selfRef.RelatedResourceId = relatedResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.IncidentRelationArgs WithRelationName(this global::Pulumi.AzureNative.SecurityInsights.IncidentRelationArgs @selfRef, global::System.String relationName)
    {
        @selfRef.RelationName = relationName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.IncidentRelationArgs WithResourceGroupName(this global::Pulumi.AzureNative.SecurityInsights.IncidentRelationArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.IncidentRelationArgs WithWorkspaceName(this global::Pulumi.AzureNative.SecurityInsights.IncidentRelationArgs @selfRef, global::System.String workspaceName)
    {
        @selfRef.WorkspaceName = workspaceName;
        return @selfRef;
    }

}
