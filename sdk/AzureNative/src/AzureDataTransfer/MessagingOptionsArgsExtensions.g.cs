// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AzureDataTransfer.Inputs;

namespace Pulumi.AzureNative.AzureDataTransfer;

public static partial class MessagingOptionsArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureDataTransfer.Inputs.MessagingOptionsArgs WithBillingTier(this global::Pulumi.AzureNative.AzureDataTransfer.Inputs.MessagingOptionsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureDataTransfer.FlowBillingTier> billingTier)
    {
        @selfRef.BillingTier = billingTier;
        return @selfRef;
    }

}
