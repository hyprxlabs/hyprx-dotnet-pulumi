// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Billing.Inputs;

namespace Pulumi.AzureNative.Billing;

public static partial class AzurePlanArgsExtensions
{
    public static global::Pulumi.AzureNative.Billing.Inputs.AzurePlanArgs WithProductId(this global::Pulumi.AzureNative.Billing.Inputs.AzurePlanArgs @selfRef, global::System.String productId)
    {
        @selfRef.ProductId = productId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Billing.Inputs.AzurePlanArgs WithSkuDescription(this global::Pulumi.AzureNative.Billing.Inputs.AzurePlanArgs @selfRef, global::System.String skuDescription)
    {
        @selfRef.SkuDescription = skuDescription;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Billing.Inputs.AzurePlanArgs WithSkuId(this global::Pulumi.AzureNative.Billing.Inputs.AzurePlanArgs @selfRef, global::System.String skuId)
    {
        @selfRef.SkuId = skuId;
        return @selfRef;
    }

}
