// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.WaFv2.Inputs;

namespace Pulumi.AwsNative.WaFv2;

public static partial class RuleGroupChallengeActionArgsExtensions
{
    public static global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupChallengeActionArgs WithCustomRequestHandling(this global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupChallengeActionArgs @selfRef, global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupCustomRequestHandlingArgs customRequestHandling)
    {
        @selfRef.CustomRequestHandling = customRequestHandling;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupChallengeActionArgs WithCustomRequestHandling(this global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupChallengeActionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupCustomRequestHandlingArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupCustomRequestHandlingArgs();
        @configure(@item);
        @selfRef.CustomRequestHandling = @item;
        return @selfRef;
    }

}
