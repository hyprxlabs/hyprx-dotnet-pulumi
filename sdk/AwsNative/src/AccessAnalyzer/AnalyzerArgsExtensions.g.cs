// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.AccessAnalyzer;

public static partial class AnalyzerArgsExtensions
{
    public static global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs WithAnalyzerConfiguration(this global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs @selfRef, global::Pulumi.AwsNative.AccessAnalyzer.Inputs.AnalyzerConfigurationPropertiesArgs analyzerConfiguration)
    {
        @selfRef.AnalyzerConfiguration = analyzerConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs WithAnalyzerConfiguration(this global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AccessAnalyzer.Inputs.AnalyzerConfigurationPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.AccessAnalyzer.Inputs.AnalyzerConfigurationPropertiesArgs();
        @configure(@item);
        @selfRef.AnalyzerConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs WithAnalyzerName(this global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs @selfRef, global::System.String analyzerName)
    {
        @selfRef.AnalyzerName = analyzerName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs WithArchiveRules(this global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.AccessAnalyzer.Inputs.AnalyzerArchiveRuleArgs> archiveRules)
    {
        @selfRef.ArchiveRules = archiveRules;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs WithArchiveRules(this global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.AccessAnalyzer.Inputs.AnalyzerArchiveRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.AccessAnalyzer.Inputs.AnalyzerArchiveRuleArgs>();
        @configure(@list);
        @selfRef.ArchiveRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs WithArchiveRules(this global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.AccessAnalyzer.Inputs.AnalyzerArchiveRuleArgs>> @create)
    {
        @selfRef.ArchiveRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs WithTags(this global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs WithTags(this global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs WithTags(this global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs WithType(this global::Pulumi.AwsNative.AccessAnalyzer.AnalyzerArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
