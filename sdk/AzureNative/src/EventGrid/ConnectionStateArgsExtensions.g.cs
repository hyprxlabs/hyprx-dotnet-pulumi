// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.EventGrid.Inputs;

namespace Pulumi.AzureNative.EventGrid;

public static partial class ConnectionStateArgsExtensions
{
    public static global::Pulumi.AzureNative.EventGrid.Inputs.ConnectionStateArgs WithActionsRequired(this global::Pulumi.AzureNative.EventGrid.Inputs.ConnectionStateArgs @selfRef, global::System.String actionsRequired)
    {
        @selfRef.ActionsRequired = actionsRequired;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.ConnectionStateArgs WithDescription(this global::Pulumi.AzureNative.EventGrid.Inputs.ConnectionStateArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventGrid.Inputs.ConnectionStateArgs WithStatus(this global::Pulumi.AzureNative.EventGrid.Inputs.ConnectionStateArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.EventGrid.PersistedConnectionStatus> status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

}
