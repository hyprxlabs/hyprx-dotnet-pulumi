// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class KnowledgeBaseRdsFieldMappingArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRdsFieldMappingArgs WithCustomMetadataField(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRdsFieldMappingArgs @selfRef, global::System.String customMetadataField)
    {
        @selfRef.CustomMetadataField = customMetadataField;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRdsFieldMappingArgs WithMetadataField(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRdsFieldMappingArgs @selfRef, global::System.String metadataField)
    {
        @selfRef.MetadataField = metadataField;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRdsFieldMappingArgs WithPrimaryKeyField(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRdsFieldMappingArgs @selfRef, global::System.String primaryKeyField)
    {
        @selfRef.PrimaryKeyField = primaryKeyField;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRdsFieldMappingArgs WithTextField(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRdsFieldMappingArgs @selfRef, global::System.String textField)
    {
        @selfRef.TextField = textField;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRdsFieldMappingArgs WithVectorField(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRdsFieldMappingArgs @selfRef, global::System.String vectorField)
    {
        @selfRef.VectorField = vectorField;
        return @selfRef;
    }

}
