// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Lex.Inputs;

namespace Pulumi.AwsNative.Lex;

public static partial class BotQnAIntentConfigurationDataSourceConfigurationPropertiesBedrockKnowledgeStoreConfigurationPropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.Lex.Inputs.BotQnAIntentConfigurationDataSourceConfigurationPropertiesBedrockKnowledgeStoreConfigurationPropertiesArgs WithBedrockKnowledgeBaseArn(this global::Pulumi.AwsNative.Lex.Inputs.BotQnAIntentConfigurationDataSourceConfigurationPropertiesBedrockKnowledgeStoreConfigurationPropertiesArgs @selfRef, global::System.String bedrockKnowledgeBaseArn)
    {
        @selfRef.BedrockKnowledgeBaseArn = bedrockKnowledgeBaseArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotQnAIntentConfigurationDataSourceConfigurationPropertiesBedrockKnowledgeStoreConfigurationPropertiesArgs WithBkbExactResponseFields(this global::Pulumi.AwsNative.Lex.Inputs.BotQnAIntentConfigurationDataSourceConfigurationPropertiesBedrockKnowledgeStoreConfigurationPropertiesArgs @selfRef, global::Pulumi.AwsNative.Lex.Inputs.BotQnAIntentConfigurationDataSourceConfigurationPropertiesBedrockKnowledgeStoreConfigurationPropertiesBkbExactResponseFieldsPropertiesArgs bkbExactResponseFields)
    {
        @selfRef.BkbExactResponseFields = bkbExactResponseFields;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotQnAIntentConfigurationDataSourceConfigurationPropertiesBedrockKnowledgeStoreConfigurationPropertiesArgs WithBkbExactResponseFields(this global::Pulumi.AwsNative.Lex.Inputs.BotQnAIntentConfigurationDataSourceConfigurationPropertiesBedrockKnowledgeStoreConfigurationPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lex.Inputs.BotQnAIntentConfigurationDataSourceConfigurationPropertiesBedrockKnowledgeStoreConfigurationPropertiesBkbExactResponseFieldsPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Lex.Inputs.BotQnAIntentConfigurationDataSourceConfigurationPropertiesBedrockKnowledgeStoreConfigurationPropertiesBkbExactResponseFieldsPropertiesArgs();
        @configure(@item);
        @selfRef.BkbExactResponseFields = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotQnAIntentConfigurationDataSourceConfigurationPropertiesBedrockKnowledgeStoreConfigurationPropertiesArgs WithExactResponse(this global::Pulumi.AwsNative.Lex.Inputs.BotQnAIntentConfigurationDataSourceConfigurationPropertiesBedrockKnowledgeStoreConfigurationPropertiesArgs @selfRef, bool exactResponse = true)
    {
        @selfRef.ExactResponse = exactResponse;
        return @selfRef;
    }

}
