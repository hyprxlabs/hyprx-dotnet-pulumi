// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.VideoIndexer.Inputs;

namespace Pulumi.AzureNative.VideoIndexer;

public static partial class PrivateLinkServiceConnectionStateArgsExtensions
{
    public static global::Pulumi.AzureNative.VideoIndexer.Inputs.PrivateLinkServiceConnectionStateArgs WithActionsRequired(this global::Pulumi.AzureNative.VideoIndexer.Inputs.PrivateLinkServiceConnectionStateArgs @selfRef, global::System.String actionsRequired)
    {
        @selfRef.ActionsRequired = actionsRequired;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VideoIndexer.Inputs.PrivateLinkServiceConnectionStateArgs WithDescription(this global::Pulumi.AzureNative.VideoIndexer.Inputs.PrivateLinkServiceConnectionStateArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.VideoIndexer.Inputs.PrivateLinkServiceConnectionStateArgs WithStatus(this global::Pulumi.AzureNative.VideoIndexer.Inputs.PrivateLinkServiceConnectionStateArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.VideoIndexer.PrivateEndpointServiceConnectionStatus> status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

}
