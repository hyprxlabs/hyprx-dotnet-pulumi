// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.OperationalInsights.Inputs;

namespace Pulumi.AzureNative.OperationalInsights;

public static partial class WorkspaceSkuArgsExtensions
{
    public static global::Pulumi.AzureNative.OperationalInsights.Inputs.WorkspaceSkuArgs WithCapacityReservationLevel(this global::Pulumi.AzureNative.OperationalInsights.Inputs.WorkspaceSkuArgs @selfRef, global::System.Int32 capacityReservationLevel)
    {
        @selfRef.CapacityReservationLevel = capacityReservationLevel;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.OperationalInsights.Inputs.WorkspaceSkuArgs WithName(this global::Pulumi.AzureNative.OperationalInsights.Inputs.WorkspaceSkuArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.OperationalInsights.WorkspaceSkuNameEnum> name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

}
