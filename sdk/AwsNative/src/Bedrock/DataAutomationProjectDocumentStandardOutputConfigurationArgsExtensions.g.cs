// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class DataAutomationProjectDocumentStandardOutputConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentStandardOutputConfigurationArgs WithExtraction(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentStandardOutputConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentStandardExtractionArgs extraction)
    {
        @selfRef.Extraction = extraction;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentStandardOutputConfigurationArgs WithExtraction(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentStandardOutputConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentStandardExtractionArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentStandardExtractionArgs();
        @configure(@item);
        @selfRef.Extraction = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentStandardOutputConfigurationArgs WithGenerativeField(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentStandardOutputConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentStandardGenerativeFieldArgs generativeField)
    {
        @selfRef.GenerativeField = generativeField;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentStandardOutputConfigurationArgs WithGenerativeField(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentStandardOutputConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentStandardGenerativeFieldArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentStandardGenerativeFieldArgs();
        @configure(@item);
        @selfRef.GenerativeField = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentStandardOutputConfigurationArgs WithOutputFormat(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentStandardOutputConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentOutputFormatArgs outputFormat)
    {
        @selfRef.OutputFormat = outputFormat;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentStandardOutputConfigurationArgs WithOutputFormat(this global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentStandardOutputConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentOutputFormatArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Bedrock.Inputs.DataAutomationProjectDocumentOutputFormatArgs();
        @configure(@item);
        @selfRef.OutputFormat = @item;
        return @selfRef;
    }

}
