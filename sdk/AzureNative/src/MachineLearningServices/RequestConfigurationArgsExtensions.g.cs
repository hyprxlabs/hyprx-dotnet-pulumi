// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class RequestConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.RequestConfigurationArgs WithMaxConcurrentRequestsPerInstance(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.RequestConfigurationArgs @selfRef, global::System.Int32 maxConcurrentRequestsPerInstance)
    {
        @selfRef.MaxConcurrentRequestsPerInstance = maxConcurrentRequestsPerInstance;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.RequestConfigurationArgs WithRequestTimeout(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.RequestConfigurationArgs @selfRef, global::System.String requestTimeout)
    {
        @selfRef.RequestTimeout = requestTimeout;
        return @selfRef;
    }

}
