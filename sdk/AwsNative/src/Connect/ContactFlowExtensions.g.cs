// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Connect;

public static partial class ContactFlowExtensions
{

    extension(ContactFlow)
    {
        public static ContactFlow New(string @id, global::Pulumi.AwsNative.Connect.ContactFlowArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ContactFlow(@id, @args, @options);
        }

        public static ContactFlow New(string @id, global::System.Action<global::Pulumi.AwsNative.Connect.ContactFlowArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Connect.ContactFlowArgs @args = new();
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

            return new ContactFlow(@id, @args, @options);
        }

    }

}
