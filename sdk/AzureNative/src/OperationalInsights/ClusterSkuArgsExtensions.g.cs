// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.OperationalInsights.Inputs;

namespace Pulumi.AzureNative.OperationalInsights;

public static partial class ClusterSkuArgsExtensions
{
    public static global::Pulumi.AzureNative.OperationalInsights.Inputs.ClusterSkuArgs WithCapacity(this global::Pulumi.AzureNative.OperationalInsights.Inputs.ClusterSkuArgs @selfRef, global::System.Double capacity)
    {
        @selfRef.Capacity = capacity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.OperationalInsights.Inputs.ClusterSkuArgs WithName(this global::Pulumi.AzureNative.OperationalInsights.Inputs.ClusterSkuArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.OperationalInsights.ClusterSkuNameEnum> name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

}
