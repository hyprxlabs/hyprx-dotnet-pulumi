// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Connect.Inputs;

namespace Pulumi.AwsNative.Connect;

public static partial class QuickConnectQueueQuickConnectConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.Connect.Inputs.QuickConnectQueueQuickConnectConfigArgs WithContactFlowArn(this global::Pulumi.AwsNative.Connect.Inputs.QuickConnectQueueQuickConnectConfigArgs @selfRef, global::System.String contactFlowArn)
    {
        @selfRef.ContactFlowArn = contactFlowArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.Inputs.QuickConnectQueueQuickConnectConfigArgs WithQueueArn(this global::Pulumi.AwsNative.Connect.Inputs.QuickConnectQueueQuickConnectConfigArgs @selfRef, global::System.String queueArn)
    {
        @selfRef.QueueArn = queueArn;
        return @selfRef;
    }

}
