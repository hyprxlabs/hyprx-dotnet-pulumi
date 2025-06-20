// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ImageBuilder.Inputs;

namespace Pulumi.AwsNative.ImageBuilder;

public static partial class DistributionConfigurationFastLaunchConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchConfigurationArgs WithAccountId(this global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchConfigurationArgs @selfRef, global::System.String accountId)
    {
        @selfRef.AccountId = accountId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchConfigurationArgs WithEnabled(this global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchConfigurationArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchConfigurationArgs WithLaunchTemplate(this global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchConfigurationArgs @selfRef, global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchLaunchTemplateSpecificationArgs launchTemplate)
    {
        @selfRef.LaunchTemplate = launchTemplate;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchConfigurationArgs WithLaunchTemplate(this global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchLaunchTemplateSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchLaunchTemplateSpecificationArgs();
        @configure(@item);
        @selfRef.LaunchTemplate = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchConfigurationArgs WithMaxParallelLaunches(this global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchConfigurationArgs @selfRef, global::System.Int32 maxParallelLaunches)
    {
        @selfRef.MaxParallelLaunches = maxParallelLaunches;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchConfigurationArgs WithSnapshotConfiguration(this global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchConfigurationArgs @selfRef, global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchSnapshotConfigurationArgs snapshotConfiguration)
    {
        @selfRef.SnapshotConfiguration = snapshotConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchConfigurationArgs WithSnapshotConfiguration(this global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchSnapshotConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.ImageBuilder.Inputs.DistributionConfigurationFastLaunchSnapshotConfigurationArgs();
        @configure(@item);
        @selfRef.SnapshotConfiguration = @item;
        return @selfRef;
    }

}
