// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.App.Inputs;

namespace Pulumi.AzureNative.App;

public static partial class CircuitBreakerPolicyArgsExtensions
{
    public static global::Pulumi.AzureNative.App.Inputs.CircuitBreakerPolicyArgs WithConsecutiveErrors(this global::Pulumi.AzureNative.App.Inputs.CircuitBreakerPolicyArgs @selfRef, global::System.Int32 consecutiveErrors)
    {
        @selfRef.ConsecutiveErrors = consecutiveErrors;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.CircuitBreakerPolicyArgs WithIntervalInSeconds(this global::Pulumi.AzureNative.App.Inputs.CircuitBreakerPolicyArgs @selfRef, global::System.Int32 intervalInSeconds)
    {
        @selfRef.IntervalInSeconds = intervalInSeconds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.CircuitBreakerPolicyArgs WithMaxEjectionPercent(this global::Pulumi.AzureNative.App.Inputs.CircuitBreakerPolicyArgs @selfRef, global::System.Int32 maxEjectionPercent)
    {
        @selfRef.MaxEjectionPercent = maxEjectionPercent;
        return @selfRef;
    }

}
