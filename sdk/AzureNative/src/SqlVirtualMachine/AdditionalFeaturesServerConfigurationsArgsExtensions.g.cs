// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.SqlVirtualMachine.Inputs;

namespace Pulumi.AzureNative.SqlVirtualMachine;

public static partial class AdditionalFeaturesServerConfigurationsArgsExtensions
{
    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AdditionalFeaturesServerConfigurationsArgs WithIsRServicesEnabled(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.AdditionalFeaturesServerConfigurationsArgs @selfRef, bool isRServicesEnabled = true)
    {
        @selfRef.IsRServicesEnabled = isRServicesEnabled;
        return @selfRef;
    }

}
