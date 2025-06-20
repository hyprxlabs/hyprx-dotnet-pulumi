// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Kendra.Inputs;

namespace Pulumi.AwsNative.Kendra;

public static partial class DataSourceInlineCustomDocumentEnrichmentConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceInlineCustomDocumentEnrichmentConfigurationArgs WithCondition(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceInlineCustomDocumentEnrichmentConfigurationArgs @selfRef, global::Pulumi.AwsNative.Kendra.Inputs.DataSourceDocumentAttributeConditionArgs condition)
    {
        @selfRef.Condition = condition;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceInlineCustomDocumentEnrichmentConfigurationArgs WithCondition(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceInlineCustomDocumentEnrichmentConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceDocumentAttributeConditionArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Kendra.Inputs.DataSourceDocumentAttributeConditionArgs();
        @configure(@item);
        @selfRef.Condition = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceInlineCustomDocumentEnrichmentConfigurationArgs WithDocumentContentDeletion(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceInlineCustomDocumentEnrichmentConfigurationArgs @selfRef, bool documentContentDeletion = true)
    {
        @selfRef.DocumentContentDeletion = documentContentDeletion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceInlineCustomDocumentEnrichmentConfigurationArgs WithTarget(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceInlineCustomDocumentEnrichmentConfigurationArgs @selfRef, global::Pulumi.AwsNative.Kendra.Inputs.DataSourceDocumentAttributeTargetArgs target)
    {
        @selfRef.Target = target;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Kendra.Inputs.DataSourceInlineCustomDocumentEnrichmentConfigurationArgs WithTarget(this global::Pulumi.AwsNative.Kendra.Inputs.DataSourceInlineCustomDocumentEnrichmentConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Kendra.Inputs.DataSourceDocumentAttributeTargetArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Kendra.Inputs.DataSourceDocumentAttributeTargetArgs();
        @configure(@item);
        @selfRef.Target = @item;
        return @selfRef;
    }

}
