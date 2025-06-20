// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Kendra.Inputs;

namespace Pulumi.AwsNative.Kendra;

public static partial class DataSourceServiceNowKnowledgeArticleConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs WithCrawlAttachments(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs @selfRef, bool crawlAttachments = true)
    {
        @selfRef.CrawlAttachments = crawlAttachments;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs WithDocumentDataFieldName(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs @selfRef, global::System.String documentDataFieldName)
    {
        @selfRef.DocumentDataFieldName = documentDataFieldName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs WithDocumentTitleFieldName(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs @selfRef, global::System.String documentTitleFieldName)
    {
        @selfRef.DocumentTitleFieldName = documentTitleFieldName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs WithExcludeAttachmentFilePatterns(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::System.String> excludeAttachmentFilePatterns)
    {
        @selfRef.ExcludeAttachmentFilePatterns = excludeAttachmentFilePatterns;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs WithExcludeAttachmentFilePatterns(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ExcludeAttachmentFilePatterns = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs WithExcludeAttachmentFilePatterns(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ExcludeAttachmentFilePatterns = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs WithFieldMappings(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceToIndexFieldMappingArgs> fieldMappings)
    {
        @selfRef.FieldMappings = fieldMappings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs WithFieldMappings(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceToIndexFieldMappingArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceToIndexFieldMappingArgs>();
        @configure(@list);
        @selfRef.FieldMappings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs WithFieldMappings(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceToIndexFieldMappingArgs>> @create)
    {
        @selfRef.FieldMappings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs WithFilterQuery(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs @selfRef, global::System.String filterQuery)
    {
        @selfRef.FilterQuery = filterQuery;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs WithIncludeAttachmentFilePatterns(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::System.String> includeAttachmentFilePatterns)
    {
        @selfRef.IncludeAttachmentFilePatterns = includeAttachmentFilePatterns;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs WithIncludeAttachmentFilePatterns(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.IncludeAttachmentFilePatterns = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs WithIncludeAttachmentFilePatterns(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceServiceNowKnowledgeArticleConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.IncludeAttachmentFilePatterns = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
