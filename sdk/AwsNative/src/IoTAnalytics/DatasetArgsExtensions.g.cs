// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.IoTAnalytics;

public static partial class DatasetArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithActions(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetActionArgs> actions)
    {
        @selfRef.Actions = actions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithActions(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetActionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetActionArgs>();
        @configure(@list);
        @selfRef.Actions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithActions(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetActionArgs>> @create)
    {
        @selfRef.Actions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithContentDeliveryRules(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetContentDeliveryRuleArgs> contentDeliveryRules)
    {
        @selfRef.ContentDeliveryRules = contentDeliveryRules;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithContentDeliveryRules(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetContentDeliveryRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetContentDeliveryRuleArgs>();
        @configure(@list);
        @selfRef.ContentDeliveryRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithContentDeliveryRules(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetContentDeliveryRuleArgs>> @create)
    {
        @selfRef.ContentDeliveryRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithDatasetName(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::System.String datasetName)
    {
        @selfRef.DatasetName = datasetName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithLateDataRules(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetLateDataRuleArgs> lateDataRules)
    {
        @selfRef.LateDataRules = lateDataRules;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithLateDataRules(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetLateDataRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetLateDataRuleArgs>();
        @configure(@list);
        @selfRef.LateDataRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithLateDataRules(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetLateDataRuleArgs>> @create)
    {
        @selfRef.LateDataRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithRetentionPeriod(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetRetentionPeriodArgs retentionPeriod)
    {
        @selfRef.RetentionPeriod = retentionPeriod;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithRetentionPeriod(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetRetentionPeriodArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetRetentionPeriodArgs();
        @configure(@item);
        @selfRef.RetentionPeriod = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithTags(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithTags(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithTags(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithTriggers(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetTriggerArgs> triggers)
    {
        @selfRef.Triggers = triggers;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithTriggers(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetTriggerArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetTriggerArgs>();
        @configure(@list);
        @selfRef.Triggers = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithTriggers(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetTriggerArgs>> @create)
    {
        @selfRef.Triggers = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithVersioningConfiguration(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetVersioningConfigurationArgs versioningConfiguration)
    {
        @selfRef.VersioningConfiguration = versioningConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs WithVersioningConfiguration(this global::Pulumi.AwsNative.IoTAnalytics.DatasetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetVersioningConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetVersioningConfigurationArgs();
        @configure(@item);
        @selfRef.VersioningConfiguration = @item;
        return @selfRef;
    }

}
