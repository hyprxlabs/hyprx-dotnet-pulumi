// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ec2;

public static partial class TransitGatewayAttachmentExtensions
{

    extension(TransitGatewayAttachment)
    {
        public static TransitGatewayAttachment New(string @id, global::Pulumi.AwsNative.Ec2.TransitGatewayAttachmentArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new TransitGatewayAttachment(@id, @args, @options);
        }

        public static TransitGatewayAttachment New(string @id, global::System.Action<global::Pulumi.AwsNative.Ec2.TransitGatewayAttachmentArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Ec2.TransitGatewayAttachmentArgs @args = new();
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

            return new TransitGatewayAttachment(@id, @args, @options);
        }

    }

}
