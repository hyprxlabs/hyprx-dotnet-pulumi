// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class PromptGenAiResourcePropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.PromptGenAiResourcePropertiesArgs WithAgent(this global::Pulumi.AwsNative.Bedrock.Inputs.PromptGenAiResourcePropertiesArgs @selfRef, global::Pulumi.AwsNative.Bedrock.Inputs.PromptAgentResourceArgs agent)
    {
        @selfRef.Agent = agent;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.PromptGenAiResourcePropertiesArgs WithAgent(this global::Pulumi.AwsNative.Bedrock.Inputs.PromptGenAiResourcePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.Inputs.PromptAgentResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Bedrock.Inputs.PromptAgentResourceArgs();
        @configure(@item);
        @selfRef.Agent = @item;
        return @selfRef;
    }

}
