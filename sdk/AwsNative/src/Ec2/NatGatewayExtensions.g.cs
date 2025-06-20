// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ec2;

public static partial class NatGatewayExtensions
{

    extension(NatGateway)
    {
        public static NatGateway New(string @id, global::Pulumi.AwsNative.Ec2.NatGatewayArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new NatGateway(@id, @args, @options);
        }

        public static NatGateway New(string @id, global::System.Action<global::Pulumi.AwsNative.Ec2.NatGatewayArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Ec2.NatGatewayArgs @args = new();
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

            return new NatGateway(@id, @args, @options);
        }

    }

}
