// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerService.Inputs;

namespace Pulumi.AzureNative.ContainerService;

public static partial class ManagedClusterMetricsProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterMetricsProfileArgs WithCostAnalysis(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterMetricsProfileArgs @selfRef, global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterCostAnalysisArgs costAnalysis)
    {
        @selfRef.CostAnalysis = costAnalysis;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterMetricsProfileArgs WithCostAnalysis(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterMetricsProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterCostAnalysisArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterCostAnalysisArgs();
        @configure(@item);
        @selfRef.CostAnalysis = @item;
        return @selfRef;
    }

}
