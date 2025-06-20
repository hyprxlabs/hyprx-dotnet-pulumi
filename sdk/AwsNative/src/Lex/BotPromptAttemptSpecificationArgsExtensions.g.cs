// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Lex.Inputs;

namespace Pulumi.AwsNative.Lex;

public static partial class BotPromptAttemptSpecificationArgsExtensions
{
    public static global::Pulumi.AwsNative.Lex.Inputs.BotPromptAttemptSpecificationArgs WithAllowInterrupt(this global::Pulumi.AwsNative.Lex.Inputs.BotPromptAttemptSpecificationArgs @selfRef, bool allowInterrupt = true)
    {
        @selfRef.AllowInterrupt = allowInterrupt;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotPromptAttemptSpecificationArgs WithAllowedInputTypes(this global::Pulumi.AwsNative.Lex.Inputs.BotPromptAttemptSpecificationArgs @selfRef, global::Pulumi.AwsNative.Lex.Inputs.BotAllowedInputTypesArgs allowedInputTypes)
    {
        @selfRef.AllowedInputTypes = allowedInputTypes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotPromptAttemptSpecificationArgs WithAllowedInputTypes(this global::Pulumi.AwsNative.Lex.Inputs.BotPromptAttemptSpecificationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lex.Inputs.BotAllowedInputTypesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Lex.Inputs.BotAllowedInputTypesArgs();
        @configure(@item);
        @selfRef.AllowedInputTypes = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotPromptAttemptSpecificationArgs WithAudioAndDtmfInputSpecification(this global::Pulumi.AwsNative.Lex.Inputs.BotPromptAttemptSpecificationArgs @selfRef, global::Pulumi.AwsNative.Lex.Inputs.BotAudioAndDtmfInputSpecificationArgs audioAndDtmfInputSpecification)
    {
        @selfRef.AudioAndDtmfInputSpecification = audioAndDtmfInputSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotPromptAttemptSpecificationArgs WithAudioAndDtmfInputSpecification(this global::Pulumi.AwsNative.Lex.Inputs.BotPromptAttemptSpecificationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lex.Inputs.BotAudioAndDtmfInputSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Lex.Inputs.BotAudioAndDtmfInputSpecificationArgs();
        @configure(@item);
        @selfRef.AudioAndDtmfInputSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotPromptAttemptSpecificationArgs WithTextInputSpecification(this global::Pulumi.AwsNative.Lex.Inputs.BotPromptAttemptSpecificationArgs @selfRef, global::Pulumi.AwsNative.Lex.Inputs.BotTextInputSpecificationArgs textInputSpecification)
    {
        @selfRef.TextInputSpecification = textInputSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotPromptAttemptSpecificationArgs WithTextInputSpecification(this global::Pulumi.AwsNative.Lex.Inputs.BotPromptAttemptSpecificationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lex.Inputs.BotTextInputSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Lex.Inputs.BotTextInputSpecificationArgs();
        @configure(@item);
        @selfRef.TextInputSpecification = @item;
        return @selfRef;
    }

}
