// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Wisdom.Inputs;

namespace Pulumi.AwsNative.Wisdom;

public static partial class AiAgentManualSearchAiAgentConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentManualSearchAiAgentConfigurationArgs WithAnswerGenerationAiGuardrailId(this global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentManualSearchAiAgentConfigurationArgs @selfRef, global::System.String answerGenerationAiGuardrailId)
    {
        @selfRef.AnswerGenerationAiGuardrailId = answerGenerationAiGuardrailId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentManualSearchAiAgentConfigurationArgs WithAnswerGenerationAiPromptId(this global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentManualSearchAiAgentConfigurationArgs @selfRef, global::System.String answerGenerationAiPromptId)
    {
        @selfRef.AnswerGenerationAiPromptId = answerGenerationAiPromptId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentManualSearchAiAgentConfigurationArgs WithAssociationConfigurations(this global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentManualSearchAiAgentConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentAssociationConfigurationArgs> associationConfigurations)
    {
        @selfRef.AssociationConfigurations = associationConfigurations;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentManualSearchAiAgentConfigurationArgs WithAssociationConfigurations(this global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentManualSearchAiAgentConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentAssociationConfigurationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentAssociationConfigurationArgs>();
        @configure(@list);
        @selfRef.AssociationConfigurations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentManualSearchAiAgentConfigurationArgs WithAssociationConfigurations(this global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentManualSearchAiAgentConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentAssociationConfigurationArgs>> @create)
    {
        @selfRef.AssociationConfigurations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentManualSearchAiAgentConfigurationArgs WithLocale(this global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentManualSearchAiAgentConfigurationArgs @selfRef, global::System.String locale)
    {
        @selfRef.Locale = locale;
        return @selfRef;
    }

}
