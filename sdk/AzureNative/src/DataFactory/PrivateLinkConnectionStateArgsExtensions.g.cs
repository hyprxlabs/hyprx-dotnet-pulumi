// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class PrivateLinkConnectionStateArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.PrivateLinkConnectionStateArgs WithActionsRequired(this global::Pulumi.AzureNative.DataFactory.Inputs.PrivateLinkConnectionStateArgs @selfRef, global::System.String actionsRequired)
    {
        @selfRef.ActionsRequired = actionsRequired;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.PrivateLinkConnectionStateArgs WithDescription(this global::Pulumi.AzureNative.DataFactory.Inputs.PrivateLinkConnectionStateArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.PrivateLinkConnectionStateArgs WithStatus(this global::Pulumi.AzureNative.DataFactory.Inputs.PrivateLinkConnectionStateArgs @selfRef, global::System.String status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

}
