// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Athena.Inputs;

namespace Pulumi.AwsNative.Athena;

public static partial class CapacityReservationCapacityAssignmentConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Athena.Inputs.CapacityReservationCapacityAssignmentConfigurationArgs WithCapacityAssignments(this global::Pulumi.AwsNative.Athena.Inputs.CapacityReservationCapacityAssignmentConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Athena.Inputs.CapacityReservationCapacityAssignmentArgs> capacityAssignments)
    {
        @selfRef.CapacityAssignments = capacityAssignments;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Athena.Inputs.CapacityReservationCapacityAssignmentConfigurationArgs WithCapacityAssignments(this global::Pulumi.AwsNative.Athena.Inputs.CapacityReservationCapacityAssignmentConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Athena.Inputs.CapacityReservationCapacityAssignmentArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Athena.Inputs.CapacityReservationCapacityAssignmentArgs>();
        @configure(@list);
        @selfRef.CapacityAssignments = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Athena.Inputs.CapacityReservationCapacityAssignmentConfigurationArgs WithCapacityAssignments(this global::Pulumi.AwsNative.Athena.Inputs.CapacityReservationCapacityAssignmentConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Athena.Inputs.CapacityReservationCapacityAssignmentArgs>> @create)
    {
        @selfRef.CapacityAssignments = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
