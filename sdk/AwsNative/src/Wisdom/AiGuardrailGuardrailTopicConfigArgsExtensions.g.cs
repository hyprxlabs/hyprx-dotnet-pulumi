// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Wisdom.Inputs;

namespace Pulumi.AwsNative.Wisdom;

public static partial class AiGuardrailGuardrailTopicConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailTopicConfigArgs WithDefinition(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailTopicConfigArgs @selfRef, global::System.String definition)
    {
        @selfRef.Definition = definition;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailTopicConfigArgs WithExamples(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailTopicConfigArgs @selfRef, global::System.Collections.Generic.List<global::System.String> examples)
    {
        @selfRef.Examples = examples;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailTopicConfigArgs WithExamples(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailTopicConfigArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Examples = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailTopicConfigArgs WithExamples(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailTopicConfigArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Examples = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailTopicConfigArgs WithName(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailTopicConfigArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailTopicConfigArgs WithType(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailTopicConfigArgs @selfRef, global::Pulumi.AwsNative.Wisdom.AiGuardrailGuardrailTopicType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailTopicConfigArgs WithType(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailTopicConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Wisdom.AiGuardrailGuardrailTopicType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Wisdom.AiGuardrailGuardrailTopicType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
