// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.EdgeOrder.Inputs;

namespace Pulumi.AzureNative.EdgeOrder;

public static partial class CustomerSubscriptionDetailsArgsExtensions
{
    public static global::Pulumi.AzureNative.EdgeOrder.Inputs.CustomerSubscriptionDetailsArgs WithLocationPlacementId(this global::Pulumi.AzureNative.EdgeOrder.Inputs.CustomerSubscriptionDetailsArgs @selfRef, global::System.String locationPlacementId)
    {
        @selfRef.LocationPlacementId = locationPlacementId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EdgeOrder.Inputs.CustomerSubscriptionDetailsArgs WithQuotaId(this global::Pulumi.AzureNative.EdgeOrder.Inputs.CustomerSubscriptionDetailsArgs @selfRef, global::System.String quotaId)
    {
        @selfRef.QuotaId = quotaId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EdgeOrder.Inputs.CustomerSubscriptionDetailsArgs WithRegisteredFeatures(this global::Pulumi.AzureNative.EdgeOrder.Inputs.CustomerSubscriptionDetailsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.EdgeOrder.Inputs.CustomerSubscriptionRegisteredFeaturesArgs> registeredFeatures)
    {
        @selfRef.RegisteredFeatures = registeredFeatures;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EdgeOrder.Inputs.CustomerSubscriptionDetailsArgs WithRegisteredFeatures(this global::Pulumi.AzureNative.EdgeOrder.Inputs.CustomerSubscriptionDetailsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.EdgeOrder.Inputs.CustomerSubscriptionRegisteredFeaturesArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.EdgeOrder.Inputs.CustomerSubscriptionRegisteredFeaturesArgs>();
        @configure(@list);
        @selfRef.RegisteredFeatures = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EdgeOrder.Inputs.CustomerSubscriptionDetailsArgs WithRegisteredFeatures(this global::Pulumi.AzureNative.EdgeOrder.Inputs.CustomerSubscriptionDetailsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.EdgeOrder.Inputs.CustomerSubscriptionRegisteredFeaturesArgs>> @create)
    {
        @selfRef.RegisteredFeatures = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
