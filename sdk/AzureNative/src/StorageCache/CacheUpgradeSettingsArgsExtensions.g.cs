// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.StorageCache.Inputs;

namespace Pulumi.AzureNative.StorageCache;

public static partial class CacheUpgradeSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.StorageCache.Inputs.CacheUpgradeSettingsArgs WithScheduledTime(this global::Pulumi.AzureNative.StorageCache.Inputs.CacheUpgradeSettingsArgs @selfRef, global::System.String scheduledTime)
    {
        @selfRef.ScheduledTime = scheduledTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageCache.Inputs.CacheUpgradeSettingsArgs WithUpgradeScheduleEnabled(this global::Pulumi.AzureNative.StorageCache.Inputs.CacheUpgradeSettingsArgs @selfRef, bool upgradeScheduleEnabled = true)
    {
        @selfRef.UpgradeScheduleEnabled = upgradeScheduleEnabled;
        return @selfRef;
    }

}
