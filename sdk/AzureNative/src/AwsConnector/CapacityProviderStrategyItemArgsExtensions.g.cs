// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class CapacityProviderStrategyItemArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.CapacityProviderStrategyItemArgs WithBase(this global::Pulumi.AzureNative.AwsConnector.Inputs.CapacityProviderStrategyItemArgs @selfRef, global::System.Int32 @base)
    {
        @selfRef.Base = @base;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.CapacityProviderStrategyItemArgs WithCapacityProvider(this global::Pulumi.AzureNative.AwsConnector.Inputs.CapacityProviderStrategyItemArgs @selfRef, global::System.String capacityProvider)
    {
        @selfRef.CapacityProvider = capacityProvider;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.CapacityProviderStrategyItemArgs WithWeight(this global::Pulumi.AzureNative.AwsConnector.Inputs.CapacityProviderStrategyItemArgs @selfRef, global::System.Int32 weight)
    {
        @selfRef.Weight = weight;
        return @selfRef;
    }

}
