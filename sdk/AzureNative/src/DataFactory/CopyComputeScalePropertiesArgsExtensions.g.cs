// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class CopyComputeScalePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.CopyComputeScalePropertiesArgs WithDataIntegrationUnit(this global::Pulumi.AzureNative.DataFactory.Inputs.CopyComputeScalePropertiesArgs @selfRef, global::System.Int32 dataIntegrationUnit)
    {
        @selfRef.DataIntegrationUnit = dataIntegrationUnit;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.CopyComputeScalePropertiesArgs WithTimeToLive(this global::Pulumi.AzureNative.DataFactory.Inputs.CopyComputeScalePropertiesArgs @selfRef, global::System.Int32 timeToLive)
    {
        @selfRef.TimeToLive = timeToLive;
        return @selfRef;
    }

}
