// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ServiceFabric.Inputs;

namespace Pulumi.AzureNative.ServiceFabric;

public static partial class ClusterUpgradeDeltaHealthPolicyArgsExtensions
{
    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.ClusterUpgradeDeltaHealthPolicyArgs WithMaxPercentDeltaUnhealthyApplications(this global::Pulumi.AzureNative.ServiceFabric.Inputs.ClusterUpgradeDeltaHealthPolicyArgs @selfRef, global::System.Int32 maxPercentDeltaUnhealthyApplications)
    {
        @selfRef.MaxPercentDeltaUnhealthyApplications = maxPercentDeltaUnhealthyApplications;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.ClusterUpgradeDeltaHealthPolicyArgs WithMaxPercentDeltaUnhealthyNodes(this global::Pulumi.AzureNative.ServiceFabric.Inputs.ClusterUpgradeDeltaHealthPolicyArgs @selfRef, global::System.Int32 maxPercentDeltaUnhealthyNodes)
    {
        @selfRef.MaxPercentDeltaUnhealthyNodes = maxPercentDeltaUnhealthyNodes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.ClusterUpgradeDeltaHealthPolicyArgs WithMaxPercentUpgradeDomainDeltaUnhealthyNodes(this global::Pulumi.AzureNative.ServiceFabric.Inputs.ClusterUpgradeDeltaHealthPolicyArgs @selfRef, global::System.Int32 maxPercentUpgradeDomainDeltaUnhealthyNodes)
    {
        @selfRef.MaxPercentUpgradeDomainDeltaUnhealthyNodes = maxPercentUpgradeDomainDeltaUnhealthyNodes;
        return @selfRef;
    }

}
