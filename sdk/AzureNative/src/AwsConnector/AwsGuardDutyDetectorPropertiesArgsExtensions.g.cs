// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class AwsGuardDutyDetectorPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs WithDataSources(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.CFNDataSourceConfigurationsArgs dataSources)
    {
        @selfRef.DataSources = dataSources;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs WithDataSources(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.CFNDataSourceConfigurationsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.CFNDataSourceConfigurationsArgs();
        @configure(@item);
        @selfRef.DataSources = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs WithEnable(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs @selfRef, bool enable = true)
    {
        @selfRef.Enable = enable;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs WithFeatures(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.CFNFeatureConfigurationArgs> features)
    {
        @selfRef.Features = features;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs WithFeatures(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.CFNFeatureConfigurationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.CFNFeatureConfigurationArgs>();
        @configure(@list);
        @selfRef.Features = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs WithFeatures(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.CFNFeatureConfigurationArgs>> @create)
    {
        @selfRef.Features = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs WithFindingPublishingFrequency(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs @selfRef, global::System.String findingPublishingFrequency)
    {
        @selfRef.FindingPublishingFrequency = findingPublishingFrequency;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs WithId(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TagItemArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TagItemArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TagItemArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsGuardDutyDetectorPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.TagItemArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
