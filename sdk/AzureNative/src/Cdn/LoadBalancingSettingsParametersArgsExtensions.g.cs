// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Cdn.Inputs;

namespace Pulumi.AzureNative.Cdn;

public static partial class LoadBalancingSettingsParametersArgsExtensions
{
    public static global::Pulumi.AzureNative.Cdn.Inputs.LoadBalancingSettingsParametersArgs WithAdditionalLatencyInMilliseconds(this global::Pulumi.AzureNative.Cdn.Inputs.LoadBalancingSettingsParametersArgs @selfRef, global::System.Int32 additionalLatencyInMilliseconds)
    {
        @selfRef.AdditionalLatencyInMilliseconds = additionalLatencyInMilliseconds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.LoadBalancingSettingsParametersArgs WithSampleSize(this global::Pulumi.AzureNative.Cdn.Inputs.LoadBalancingSettingsParametersArgs @selfRef, global::System.Int32 sampleSize)
    {
        @selfRef.SampleSize = sampleSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.LoadBalancingSettingsParametersArgs WithSuccessfulSamplesRequired(this global::Pulumi.AzureNative.Cdn.Inputs.LoadBalancingSettingsParametersArgs @selfRef, global::System.Int32 successfulSamplesRequired)
    {
        @selfRef.SuccessfulSamplesRequired = successfulSamplesRequired;
        return @selfRef;
    }

}
