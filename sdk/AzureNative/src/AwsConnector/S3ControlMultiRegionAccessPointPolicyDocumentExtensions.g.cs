// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AwsConnector;

public static partial class S3ControlMultiRegionAccessPointPolicyDocumentExtensions
{

    extension(S3ControlMultiRegionAccessPointPolicyDocument)
    {
        public static S3ControlMultiRegionAccessPointPolicyDocument New(string @id, global::Pulumi.AzureNative.AwsConnector.S3ControlMultiRegionAccessPointPolicyDocumentArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new S3ControlMultiRegionAccessPointPolicyDocument(@id, @args, @options);
        }

        public static S3ControlMultiRegionAccessPointPolicyDocument New(string @id, global::System.Action<global::Pulumi.AzureNative.AwsConnector.S3ControlMultiRegionAccessPointPolicyDocumentArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.AwsConnector.S3ControlMultiRegionAccessPointPolicyDocumentArgs @args = new();
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

            return new S3ControlMultiRegionAccessPointPolicyDocument(@id, @args, @options);
        }

    }

}
