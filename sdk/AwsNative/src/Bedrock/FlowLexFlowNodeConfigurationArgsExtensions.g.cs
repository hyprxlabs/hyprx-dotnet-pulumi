// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class FlowLexFlowNodeConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.FlowLexFlowNodeConfigurationArgs WithBotAliasArn(this global::Pulumi.AwsNative.Bedrock.Inputs.FlowLexFlowNodeConfigurationArgs @selfRef, global::System.String botAliasArn)
    {
        @selfRef.BotAliasArn = botAliasArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.FlowLexFlowNodeConfigurationArgs WithLocaleId(this global::Pulumi.AwsNative.Bedrock.Inputs.FlowLexFlowNodeConfigurationArgs @selfRef, global::System.String localeId)
    {
        @selfRef.LocaleId = localeId;
        return @selfRef;
    }

}
