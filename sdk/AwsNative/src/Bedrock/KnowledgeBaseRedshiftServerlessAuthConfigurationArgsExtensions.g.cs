// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class KnowledgeBaseRedshiftServerlessAuthConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftServerlessAuthConfigurationArgs WithType(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftServerlessAuthConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.KnowledgeBaseRedshiftServerlessAuthType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftServerlessAuthConfigurationArgs WithType(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftServerlessAuthConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.KnowledgeBaseRedshiftServerlessAuthType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Bedrock.KnowledgeBaseRedshiftServerlessAuthType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftServerlessAuthConfigurationArgs WithUsernamePasswordSecretArn(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftServerlessAuthConfigurationArgs @selfRef, global::System.String usernamePasswordSecretArn)
    {
        @selfRef.UsernamePasswordSecretArn = usernamePasswordSecretArn;
        return @selfRef;
    }

}
