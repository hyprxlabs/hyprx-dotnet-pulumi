// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.NetworkManager;

public static partial class ConnectAttachmentExtensions
{

    extension(ConnectAttachment)
    {
        public static ConnectAttachment New(string @id, global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ConnectAttachment(@id, @args, @options);
        }

        public static ConnectAttachment New(string @id, global::System.Action<global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs @args = new();
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

            return new ConnectAttachment(@id, @args, @options);
        }

    }

}
