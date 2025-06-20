// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class KnowledgeBasePineconeConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBasePineconeConfigurationArgs WithConnectionString(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBasePineconeConfigurationArgs @selfRef, global::System.String connectionString)
    {
        @selfRef.ConnectionString = connectionString;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBasePineconeConfigurationArgs WithCredentialsSecretArn(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBasePineconeConfigurationArgs @selfRef, global::System.String credentialsSecretArn)
    {
        @selfRef.CredentialsSecretArn = credentialsSecretArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBasePineconeConfigurationArgs WithFieldMapping(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBasePineconeConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBasePineconeFieldMappingArgs fieldMapping)
    {
        @selfRef.FieldMapping = fieldMapping;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBasePineconeConfigurationArgs WithFieldMapping(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBasePineconeConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBasePineconeFieldMappingArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBasePineconeFieldMappingArgs();
        @configure(@item);
        @selfRef.FieldMapping = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBasePineconeConfigurationArgs WithNamespace(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBasePineconeConfigurationArgs @selfRef, global::System.String @namespace)
    {
        @selfRef.Namespace = @namespace;
        return @selfRef;
    }

}
