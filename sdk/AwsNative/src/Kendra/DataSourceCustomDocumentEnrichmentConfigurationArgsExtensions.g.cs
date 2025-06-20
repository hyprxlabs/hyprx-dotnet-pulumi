// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Kendra.Inputs;

namespace Pulumi.AwsNative.Kendra;

public static partial class DataSourceCustomDocumentEnrichmentConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceCustomDocumentEnrichmentConfigurationArgs WithInlineConfigurations(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceCustomDocumentEnrichmentConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceInlineCustomDocumentEnrichmentConfigurationArgs> inlineConfigurations)
    {
        @selfRef.InlineConfigurations = inlineConfigurations;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceCustomDocumentEnrichmentConfigurationArgs WithInlineConfigurations(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceCustomDocumentEnrichmentConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceInlineCustomDocumentEnrichmentConfigurationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceInlineCustomDocumentEnrichmentConfigurationArgs>();
        @configure(@list);
        @selfRef.InlineConfigurations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceCustomDocumentEnrichmentConfigurationArgs WithInlineConfigurations(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceCustomDocumentEnrichmentConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceInlineCustomDocumentEnrichmentConfigurationArgs>> @create)
    {
        @selfRef.InlineConfigurations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceCustomDocumentEnrichmentConfigurationArgs WithPostExtractionHookConfiguration(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceCustomDocumentEnrichmentConfigurationArgs @selfRef, global::Pulumi.AwsNative.Kendra.Inputs.DataSourceHookConfigurationArgs postExtractionHookConfiguration)
    {
        @selfRef.PostExtractionHookConfiguration = postExtractionHookConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceCustomDocumentEnrichmentConfigurationArgs WithPostExtractionHookConfiguration(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceCustomDocumentEnrichmentConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceHookConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Kendra.Inputs.DataSourceHookConfigurationArgs();
        @configure(@item);
        @selfRef.PostExtractionHookConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceCustomDocumentEnrichmentConfigurationArgs WithPreExtractionHookConfiguration(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceCustomDocumentEnrichmentConfigurationArgs @selfRef, global::Pulumi.AwsNative.Kendra.Inputs.DataSourceHookConfigurationArgs preExtractionHookConfiguration)
    {
        @selfRef.PreExtractionHookConfiguration = preExtractionHookConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceCustomDocumentEnrichmentConfigurationArgs WithPreExtractionHookConfiguration(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceCustomDocumentEnrichmentConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceHookConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Kendra.Inputs.DataSourceHookConfigurationArgs();
        @configure(@item);
        @selfRef.PreExtractionHookConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceCustomDocumentEnrichmentConfigurationArgs WithRoleArn(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceCustomDocumentEnrichmentConfigurationArgs @selfRef, global::System.String roleArn)
    {
        @selfRef.RoleArn = roleArn;
        return @selfRef;
    }

}
