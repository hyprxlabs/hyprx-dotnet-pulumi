// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class PromptMessageArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.PromptMessageArgs WithContent(this global::Pulumi.AwsNative.Bedrock.Inputs.PromptMessageArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::Pulumi.AwsNative.Bedrock.Inputs.PromptContentBlock0PropertiesArgs, global::Pulumi.AwsNative.Bedrock.Inputs.PromptContentBlock1PropertiesArgs>> content)
    {
        @selfRef.Content = content;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.PromptMessageArgs WithContent(this global::Pulumi.AwsNative.Bedrock.Inputs.PromptMessageArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::Pulumi.AwsNative.Bedrock.Inputs.PromptContentBlock0PropertiesArgs, global::Pulumi.AwsNative.Bedrock.Inputs.PromptContentBlock1PropertiesArgs>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::Pulumi.AwsNative.Bedrock.Inputs.PromptContentBlock0PropertiesArgs, global::Pulumi.AwsNative.Bedrock.Inputs.PromptContentBlock1PropertiesArgs>>();
        @configure(@list);
        @selfRef.Content = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.PromptMessageArgs WithContent(this global::Pulumi.AwsNative.Bedrock.Inputs.PromptMessageArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::Pulumi.AwsNative.Bedrock.Inputs.PromptContentBlock0PropertiesArgs, global::Pulumi.AwsNative.Bedrock.Inputs.PromptContentBlock1PropertiesArgs>>> @create)
    {
        @selfRef.Content = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.PromptMessageArgs WithRole(this global::Pulumi.AwsNative.Bedrock.Inputs.PromptMessageArgs @selfRef, global::Pulumi.AwsNative.Bedrock.PromptConversationRole role)
    {
        @selfRef.Role = role;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.PromptMessageArgs WithRole(this global::Pulumi.AwsNative.Bedrock.Inputs.PromptMessageArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.PromptConversationRole> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Bedrock.PromptConversationRole>();
        @configure(@item);
        @selfRef.Role = @item;
        return @selfRef;
    }

}
