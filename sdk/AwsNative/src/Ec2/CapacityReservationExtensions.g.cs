// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ec2;

public static partial class CapacityReservationExtensions
{

    extension(CapacityReservation)
    {
        public static CapacityReservation New(string @id, global::Pulumi.AwsNative.Ec2.CapacityReservationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new CapacityReservation(@id, @args, @options);
        }

        public static CapacityReservation New(string @id, global::System.Action<global::Pulumi.AwsNative.Ec2.CapacityReservationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Ec2.CapacityReservationArgs @args = new();
            global::Pulumi.CustomResourceOptions? @options = null;
            if (@configureArgs is not null)
            {
                @configureArgs(@args);
            }

            if (@configureOptions is not null)
            {
                @options = new();
                @configureOptions(@options);
            }

            return new CapacityReservation(@id, @args, @options);
        }

    }

}
