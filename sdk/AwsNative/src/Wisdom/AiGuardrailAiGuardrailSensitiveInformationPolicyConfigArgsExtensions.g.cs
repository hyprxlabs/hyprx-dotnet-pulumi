// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Wisdom.Inputs;

namespace Pulumi.AwsNative.Wisdom;

public static partial class AiGuardrailAiGuardrailSensitiveInformationPolicyConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailAiGuardrailSensitiveInformationPolicyConfigArgs WithPiiEntitiesConfig(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailAiGuardrailSensitiveInformationPolicyConfigArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailPiiEntityConfigArgs> piiEntitiesConfig)
    {
        @selfRef.PiiEntitiesConfig = piiEntitiesConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailAiGuardrailSensitiveInformationPolicyConfigArgs WithPiiEntitiesConfig(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailAiGuardrailSensitiveInformationPolicyConfigArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailPiiEntityConfigArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailPiiEntityConfigArgs>();
        @configure(@list);
        @selfRef.PiiEntitiesConfig = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailAiGuardrailSensitiveInformationPolicyConfigArgs WithPiiEntitiesConfig(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailAiGuardrailSensitiveInformationPolicyConfigArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailPiiEntityConfigArgs>> @create)
    {
        @selfRef.PiiEntitiesConfig = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailAiGuardrailSensitiveInformationPolicyConfigArgs WithRegexesConfig(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailAiGuardrailSensitiveInformationPolicyConfigArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailRegexConfigArgs> regexesConfig)
    {
        @selfRef.RegexesConfig = regexesConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailAiGuardrailSensitiveInformationPolicyConfigArgs WithRegexesConfig(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailAiGuardrailSensitiveInformationPolicyConfigArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailRegexConfigArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailRegexConfigArgs>();
        @configure(@list);
        @selfRef.RegexesConfig = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailAiGuardrailSensitiveInformationPolicyConfigArgs WithRegexesConfig(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailAiGuardrailSensitiveInformationPolicyConfigArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailRegexConfigArgs>> @create)
    {
        @selfRef.RegexesConfig = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
