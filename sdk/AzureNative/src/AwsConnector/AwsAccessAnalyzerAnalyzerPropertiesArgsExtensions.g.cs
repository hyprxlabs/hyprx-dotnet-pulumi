// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class AwsAccessAnalyzerAnalyzerPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs WithAnalyzerConfiguration(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.UnusedAccessConfigurationArgs analyzerConfiguration)
    {
        @selfRef.AnalyzerConfiguration = analyzerConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs WithAnalyzerConfiguration(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.UnusedAccessConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.UnusedAccessConfigurationArgs();
        @configure(@item);
        @selfRef.AnalyzerConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs WithAnalyzerName(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs @selfRef, global::System.String analyzerName)
    {
        @selfRef.AnalyzerName = analyzerName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs WithArchiveRules(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.ArchiveRuleArgs> archiveRules)
    {
        @selfRef.ArchiveRules = archiveRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs WithArchiveRules(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.ArchiveRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.ArchiveRuleArgs>();
        @configure(@list);
        @selfRef.ArchiveRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs WithArchiveRules(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.ArchiveRuleArgs>> @create)
    {
        @selfRef.ArchiveRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs WithArn(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs @selfRef, global::System.String arn)
    {
        @selfRef.Arn = arn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs WithType(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsAccessAnalyzerAnalyzerPropertiesArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
