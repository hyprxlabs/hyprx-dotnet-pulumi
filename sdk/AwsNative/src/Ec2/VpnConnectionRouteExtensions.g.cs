// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ec2;

public static partial class VpnConnectionRouteExtensions
{

    extension(VpnConnectionRoute)
    {
        public static VpnConnectionRoute New(string @id, global::Pulumi.AwsNative.Ec2.VpnConnectionRouteArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new VpnConnectionRoute(@id, @args, @options);
        }

        public static VpnConnectionRoute New(string @id, global::System.Action<global::Pulumi.AwsNative.Ec2.VpnConnectionRouteArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Ec2.VpnConnectionRouteArgs @args = new();
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

            return new VpnConnectionRoute(@id, @args, @options);
        }

    }

}
