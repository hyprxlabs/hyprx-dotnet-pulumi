// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.StreamAnalytics.Inputs;

namespace Pulumi.AzureNative.StreamAnalytics;

public static partial class SkuArgsExtensions
{
    public static global::Pulumi.AzureNative.StreamAnalytics.Inputs.SkuArgs WithName(this global::Pulumi.AzureNative.StreamAnalytics.Inputs.SkuArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.StreamAnalytics.SkuName> name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

}
