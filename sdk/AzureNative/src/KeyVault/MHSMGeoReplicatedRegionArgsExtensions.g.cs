// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.KeyVault.Inputs;

namespace Pulumi.AzureNative.KeyVault;

public static partial class MHSMGeoReplicatedRegionArgsExtensions
{
    public static global::Pulumi.AzureNative.KeyVault.Inputs.MHSMGeoReplicatedRegionArgs WithIsPrimary(this global::Pulumi.AzureNative.KeyVault.Inputs.MHSMGeoReplicatedRegionArgs @selfRef, bool isPrimary = true)
    {
        @selfRef.IsPrimary = isPrimary;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.MHSMGeoReplicatedRegionArgs WithName(this global::Pulumi.AzureNative.KeyVault.Inputs.MHSMGeoReplicatedRegionArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

}
