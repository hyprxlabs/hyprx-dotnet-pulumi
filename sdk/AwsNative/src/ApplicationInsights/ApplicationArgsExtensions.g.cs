// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.ApplicationInsights;

public static partial class ApplicationArgsExtensions
{
    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithAttachMissingPermission(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, bool attachMissingPermission = true)
    {
        @selfRef.AttachMissingPermission = attachMissingPermission;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithAutoConfigurationEnabled(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, bool autoConfigurationEnabled = true)
    {
        @selfRef.AutoConfigurationEnabled = autoConfigurationEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithComponentMonitoringSettings(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.ApplicationInsights.Inputs.ApplicationComponentMonitoringSettingArgs> componentMonitoringSettings)
    {
        @selfRef.ComponentMonitoringSettings = componentMonitoringSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithComponentMonitoringSettings(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.ApplicationInsights.Inputs.ApplicationComponentMonitoringSettingArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.ApplicationInsights.Inputs.ApplicationComponentMonitoringSettingArgs>();
        @configure(@list);
        @selfRef.ComponentMonitoringSettings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithComponentMonitoringSettings(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.ApplicationInsights.Inputs.ApplicationComponentMonitoringSettingArgs>> @create)
    {
        @selfRef.ComponentMonitoringSettings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithCustomComponents(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.ApplicationInsights.Inputs.ApplicationCustomComponentArgs> customComponents)
    {
        @selfRef.CustomComponents = customComponents;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithCustomComponents(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.ApplicationInsights.Inputs.ApplicationCustomComponentArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.ApplicationInsights.Inputs.ApplicationCustomComponentArgs>();
        @configure(@list);
        @selfRef.CustomComponents = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithCustomComponents(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.ApplicationInsights.Inputs.ApplicationCustomComponentArgs>> @create)
    {
        @selfRef.CustomComponents = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithCweMonitorEnabled(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, bool cweMonitorEnabled = true)
    {
        @selfRef.CweMonitorEnabled = cweMonitorEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithGroupingType(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, global::Pulumi.AwsNative.ApplicationInsights.ApplicationGroupingType groupingType)
    {
        @selfRef.GroupingType = groupingType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithGroupingType(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ApplicationInsights.ApplicationGroupingType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.ApplicationInsights.ApplicationGroupingType>();
        @configure(@item);
        @selfRef.GroupingType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithLogPatternSets(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.ApplicationInsights.Inputs.ApplicationLogPatternSetArgs> logPatternSets)
    {
        @selfRef.LogPatternSets = logPatternSets;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithLogPatternSets(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.ApplicationInsights.Inputs.ApplicationLogPatternSetArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.ApplicationInsights.Inputs.ApplicationLogPatternSetArgs>();
        @configure(@list);
        @selfRef.LogPatternSets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithLogPatternSets(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.ApplicationInsights.Inputs.ApplicationLogPatternSetArgs>> @create)
    {
        @selfRef.LogPatternSets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithOpsCenterEnabled(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, bool opsCenterEnabled = true)
    {
        @selfRef.OpsCenterEnabled = opsCenterEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithOpsItemSnsTopicArn(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, global::System.String opsItemSnsTopicArn)
    {
        @selfRef.OpsItemSnsTopicArn = opsItemSnsTopicArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithResourceGroupName(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithSnsNotificationArn(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, global::System.String snsNotificationArn)
    {
        @selfRef.SnsNotificationArn = snsNotificationArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithTags(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithTags(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs WithTags(this global::Pulumi.AwsNative.ApplicationInsights.ApplicationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
