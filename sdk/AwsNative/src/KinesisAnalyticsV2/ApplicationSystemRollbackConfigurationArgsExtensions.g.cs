// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.KinesisAnalyticsV2.Inputs;

namespace Pulumi.AwsNative.KinesisAnalyticsV2;

public static partial class ApplicationSystemRollbackConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.KinesisAnalyticsV2.Inputs.ApplicationSystemRollbackConfigurationArgs WithRollbackEnabled(this global::Pulumi.AwsNative.KinesisAnalyticsV2.Inputs.ApplicationSystemRollbackConfigurationArgs @selfRef, bool rollbackEnabled = true)
    {
        @selfRef.RollbackEnabled = rollbackEnabled;
        return @selfRef;
    }

}
