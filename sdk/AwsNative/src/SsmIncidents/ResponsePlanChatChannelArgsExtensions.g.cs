// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SsmIncidents.Inputs;

namespace Pulumi.AwsNative.SsmIncidents;

public static partial class ResponsePlanChatChannelArgsExtensions
{
    public static global::Pulumi.AwsNative.SsmIncidents.Inputs.ResponsePlanChatChannelArgs WithChatbotSns(this global::Pulumi.AwsNative.SsmIncidents.Inputs.ResponsePlanChatChannelArgs @selfRef, global::System.Collections.Generic.List<global::System.String> chatbotSns)
    {
        @selfRef.ChatbotSns = chatbotSns;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmIncidents.Inputs.ResponsePlanChatChannelArgs WithChatbotSns(this global::Pulumi.AwsNative.SsmIncidents.Inputs.ResponsePlanChatChannelArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ChatbotSns = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmIncidents.Inputs.ResponsePlanChatChannelArgs WithChatbotSns(this global::Pulumi.AwsNative.SsmIncidents.Inputs.ResponsePlanChatChannelArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ChatbotSns = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
