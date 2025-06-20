// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.CloudFormation;

public static partial class PublisherExtensions
{

    extension(Publisher)
    {
        public static Publisher New(string @id, global::Pulumi.AwsNative.CloudFormation.PublisherArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Publisher(@id, @args, @options);
        }

        public static Publisher New(string @id, global::System.Action<global::Pulumi.AwsNative.CloudFormation.PublisherArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.CloudFormation.PublisherArgs @args = new();
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

            return new Publisher(@id, @args, @options);
        }

    }

}
