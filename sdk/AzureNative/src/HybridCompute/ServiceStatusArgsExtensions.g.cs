// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HybridCompute.Inputs;

namespace Pulumi.AzureNative.HybridCompute;

public static partial class ServiceStatusArgsExtensions
{
    public static global::Pulumi.AzureNative.HybridCompute.Inputs.ServiceStatusArgs WithStartupType(this global::Pulumi.AzureNative.HybridCompute.Inputs.ServiceStatusArgs @selfRef, global::System.String startupType)
    {
        @selfRef.StartupType = startupType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridCompute.Inputs.ServiceStatusArgs WithStatus(this global::Pulumi.AzureNative.HybridCompute.Inputs.ServiceStatusArgs @selfRef, global::System.String status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

}
