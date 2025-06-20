// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ImageBuilder.Inputs;

namespace Pulumi.AwsNative.ImageBuilder;

public static partial class ImageScanningConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.ImageScanningConfigurationArgs WithEcrConfiguration(this global::Pulumi.AwsNative.ImageBuilder.Inputs.ImageScanningConfigurationArgs @selfRef, global::Pulumi.AwsNative.ImageBuilder.Inputs.ImageEcrConfigurationArgs ecrConfiguration)
    {
        @selfRef.EcrConfiguration = ecrConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.ImageScanningConfigurationArgs WithEcrConfiguration(this global::Pulumi.AwsNative.ImageBuilder.Inputs.ImageScanningConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ImageBuilder.Inputs.ImageEcrConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.ImageBuilder.Inputs.ImageEcrConfigurationArgs();
        @configure(@item);
        @selfRef.EcrConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.ImageScanningConfigurationArgs WithImageScanningEnabled(this global::Pulumi.AwsNative.ImageBuilder.Inputs.ImageScanningConfigurationArgs @selfRef, bool imageScanningEnabled = true)
    {
        @selfRef.ImageScanningEnabled = imageScanningEnabled;
        return @selfRef;
    }

}
