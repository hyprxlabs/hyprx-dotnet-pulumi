// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.KinesisAnalyticsV2.Inputs;

namespace Pulumi.AwsNative.KinesisAnalyticsV2;

public static partial class ApplicationSnapshotConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.KinesisAnalyticsV2.Inputs.ApplicationSnapshotConfigurationArgs WithSnapshotsEnabled(this global::Pulumi.AwsNative.KinesisAnalyticsV2.Inputs.ApplicationSnapshotConfigurationArgs @selfRef, bool snapshotsEnabled = true)
    {
        @selfRef.SnapshotsEnabled = snapshotsEnabled;
        return @selfRef;
    }

}
