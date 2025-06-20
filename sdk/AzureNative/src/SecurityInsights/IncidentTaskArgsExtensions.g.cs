// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.SecurityInsights;

public static partial class IncidentTaskArgsExtensions
{
    public static global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs WithCreatedBy(this global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs @selfRef, global::Pulumi.AzureNative.SecurityInsights.Inputs.ClientInfoArgs createdBy)
    {
        @selfRef.CreatedBy = createdBy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs WithCreatedBy(this global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.SecurityInsights.Inputs.ClientInfoArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.SecurityInsights.Inputs.ClientInfoArgs();
        @configure(@item);
        @selfRef.CreatedBy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs WithDescription(this global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs WithIncidentId(this global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs @selfRef, global::System.String incidentId)
    {
        @selfRef.IncidentId = incidentId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs WithIncidentTaskId(this global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs @selfRef, global::System.String incidentTaskId)
    {
        @selfRef.IncidentTaskId = incidentTaskId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs WithLastModifiedBy(this global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs @selfRef, global::Pulumi.AzureNative.SecurityInsights.Inputs.ClientInfoArgs lastModifiedBy)
    {
        @selfRef.LastModifiedBy = lastModifiedBy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs WithLastModifiedBy(this global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.SecurityInsights.Inputs.ClientInfoArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.SecurityInsights.Inputs.ClientInfoArgs();
        @configure(@item);
        @selfRef.LastModifiedBy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs WithResourceGroupName(this global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs WithStatus(this global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.SecurityInsights.IncidentTaskStatus> status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs WithTitle(this global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs @selfRef, global::System.String title)
    {
        @selfRef.Title = title;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs WithWorkspaceName(this global::Pulumi.AzureNative.SecurityInsights.IncidentTaskArgs @selfRef, global::System.String workspaceName)
    {
        @selfRef.WorkspaceName = workspaceName;
        return @selfRef;
    }

}
