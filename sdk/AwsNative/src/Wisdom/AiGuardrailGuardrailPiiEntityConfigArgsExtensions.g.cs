// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Wisdom.Inputs;

namespace Pulumi.AwsNative.Wisdom;

public static partial class AiGuardrailGuardrailPiiEntityConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailPiiEntityConfigArgs WithAction(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailPiiEntityConfigArgs @selfRef, global::Pulumi.AwsNative.Wisdom.AiGuardrailGuardrailSensitiveInformationAction action)
    {
        @selfRef.Action = action;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailPiiEntityConfigArgs WithAction(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailPiiEntityConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Wisdom.AiGuardrailGuardrailSensitiveInformationAction> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Wisdom.AiGuardrailGuardrailSensitiveInformationAction>();
        @configure(@item);
        @selfRef.Action = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailPiiEntityConfigArgs WithType(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailPiiEntityConfigArgs @selfRef, global::Pulumi.AwsNative.Wisdom.AiGuardrailGuardrailPiiEntityType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailPiiEntityConfigArgs WithType(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailPiiEntityConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Wisdom.AiGuardrailGuardrailPiiEntityType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Wisdom.AiGuardrailGuardrailPiiEntityType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
