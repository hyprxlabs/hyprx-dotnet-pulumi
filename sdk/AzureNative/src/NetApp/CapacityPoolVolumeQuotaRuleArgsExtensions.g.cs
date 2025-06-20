// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.NetApp;

public static partial class CapacityPoolVolumeQuotaRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs WithAccountName(this global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs @selfRef, global::System.String accountName)
    {
        @selfRef.AccountName = accountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs WithLocation(this global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs WithPoolName(this global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs @selfRef, global::System.String poolName)
    {
        @selfRef.PoolName = poolName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs WithQuotaSizeInKiBs(this global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs @selfRef, global::System.Double quotaSizeInKiBs)
    {
        @selfRef.QuotaSizeInKiBs = quotaSizeInKiBs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs WithQuotaTarget(this global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs @selfRef, global::System.String quotaTarget)
    {
        @selfRef.QuotaTarget = quotaTarget;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs WithQuotaType(this global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.NetApp.Type> quotaType)
    {
        @selfRef.QuotaType = quotaType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs WithResourceGroupName(this global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs WithTags(this global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs WithTags(this global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs WithTags(this global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs WithVolumeName(this global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs @selfRef, global::System.String volumeName)
    {
        @selfRef.VolumeName = volumeName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs WithVolumeQuotaRuleName(this global::Pulumi.AzureNative.NetApp.CapacityPoolVolumeQuotaRuleArgs @selfRef, global::System.String volumeQuotaRuleName)
    {
        @selfRef.VolumeQuotaRuleName = volumeQuotaRuleName;
        return @selfRef;
    }

}
