// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.WaFv2.Inputs;

namespace Pulumi.AwsNative.WaFv2;

public static partial class WebAclRateLimitJa3FingerprintArgsExtensions
{
    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclRateLimitJa3FingerprintArgs WithFallbackBehavior(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclRateLimitJa3FingerprintArgs @selfRef, global::Pulumi.AwsNative.WaFv2.WebAclRateLimitJa3FingerprintFallbackBehavior fallbackBehavior)
    {
        @selfRef.FallbackBehavior = fallbackBehavior;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclRateLimitJa3FingerprintArgs WithFallbackBehavior(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclRateLimitJa3FingerprintArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.WaFv2.WebAclRateLimitJa3FingerprintFallbackBehavior> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.WaFv2.WebAclRateLimitJa3FingerprintFallbackBehavior>();
        @configure(@item);
        @selfRef.FallbackBehavior = @item;
        return @selfRef;
    }

}
