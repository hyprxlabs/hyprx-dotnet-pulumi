// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class CapacityReservationFleetTagSpecificationArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.CapacityReservationFleetTagSpecificationArgs WithResourceType(this global::Pulumi.AwsNative.Ec2.Inputs.CapacityReservationFleetTagSpecificationArgs @selfRef, global::System.String resourceType)
    {
        @selfRef.ResourceType = resourceType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.CapacityReservationFleetTagSpecificationArgs WithTags(this global::Pulumi.AwsNative.Ec2.Inputs.CapacityReservationFleetTagSpecificationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.CapacityReservationFleetTagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.CapacityReservationFleetTagSpecificationArgs WithTags(this global::Pulumi.AwsNative.Ec2.Inputs.CapacityReservationFleetTagSpecificationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.CapacityReservationFleetTagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.CapacityReservationFleetTagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.CapacityReservationFleetTagSpecificationArgs WithTags(this global::Pulumi.AwsNative.Ec2.Inputs.CapacityReservationFleetTagSpecificationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ec2.Inputs.CapacityReservationFleetTagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
