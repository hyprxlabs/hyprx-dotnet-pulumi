// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Events.Inputs;

namespace Pulumi.AwsNative.Events;

public static partial class RuleBatchRetryStrategyArgsExtensions
{
    public static global::Pulumi.AwsNative.Events.Inputs.RuleBatchRetryStrategyArgs WithAttempts(this global::Pulumi.AwsNative.Events.Inputs.RuleBatchRetryStrategyArgs @selfRef, global::System.Int32 attempts)
    {
        @selfRef.Attempts = attempts;
        return @selfRef;
    }

}
