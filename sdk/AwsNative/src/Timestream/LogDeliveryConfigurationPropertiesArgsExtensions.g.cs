// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Timestream.Inputs;

namespace Pulumi.AwsNative.Timestream;

public static partial class LogDeliveryConfigurationPropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.Timestream.Inputs.LogDeliveryConfigurationPropertiesArgs WithS3Configuration(this global::Pulumi.AwsNative.Timestream.Inputs.LogDeliveryConfigurationPropertiesArgs @selfRef, global::Pulumi.AwsNative.Timestream.Inputs.LogDeliveryConfigurationPropertiesS3ConfigurationPropertiesArgs s3Configuration)
    {
        @selfRef.S3Configuration = s3Configuration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Timestream.Inputs.LogDeliveryConfigurationPropertiesArgs WithS3Configuration(this global::Pulumi.AwsNative.Timestream.Inputs.LogDeliveryConfigurationPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Timestream.Inputs.LogDeliveryConfigurationPropertiesS3ConfigurationPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Timestream.Inputs.LogDeliveryConfigurationPropertiesS3ConfigurationPropertiesArgs();
        @configure(@item);
        @selfRef.S3Configuration = @item;
        return @selfRef;
    }

}
