// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class KnowledgeBaseRedshiftQueryEngineConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftQueryEngineConfigurationArgs WithProvisionedConfiguration(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftQueryEngineConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftProvisionedConfigurationArgs provisionedConfiguration)
    {
        @selfRef.ProvisionedConfiguration = provisionedConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftQueryEngineConfigurationArgs WithProvisionedConfiguration(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftQueryEngineConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftProvisionedConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftProvisionedConfigurationArgs();
        @configure(@item);
        @selfRef.ProvisionedConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftQueryEngineConfigurationArgs WithServerlessConfiguration(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftQueryEngineConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftServerlessConfigurationArgs serverlessConfiguration)
    {
        @selfRef.ServerlessConfiguration = serverlessConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftQueryEngineConfigurationArgs WithServerlessConfiguration(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftQueryEngineConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftServerlessConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftServerlessConfigurationArgs();
        @configure(@item);
        @selfRef.ServerlessConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftQueryEngineConfigurationArgs WithType(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftQueryEngineConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.KnowledgeBaseRedshiftQueryEngineType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftQueryEngineConfigurationArgs WithType(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftQueryEngineConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.KnowledgeBaseRedshiftQueryEngineType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Bedrock.KnowledgeBaseRedshiftQueryEngineType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
