// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Compute.Inputs;

namespace Pulumi.AzureNative.Compute;

public static partial class CapacityReservationProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.Compute.Inputs.CapacityReservationProfileArgs WithCapacityReservationGroup(this global::Pulumi.AzureNative.Compute.Inputs.CapacityReservationProfileArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs capacityReservationGroup)
    {
        @selfRef.CapacityReservationGroup = capacityReservationGroup;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.CapacityReservationProfileArgs WithCapacityReservationGroup(this global::Pulumi.AzureNative.Compute.Inputs.CapacityReservationProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.CapacityReservationGroup = @item;
        return @selfRef;
    }

}
