// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.BareMetalInfrastructure.Inputs;

namespace Pulumi.AzureNative.BareMetalInfrastructure;

public static partial class AzureBareMetalStorageInstanceIdentityArgsExtensions
{
    public static global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.AzureBareMetalStorageInstanceIdentityArgs WithType(this global::Pulumi.AzureNative.BareMetalInfrastructure.Inputs.AzureBareMetalStorageInstanceIdentityArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.BareMetalInfrastructure.ResourceIdentityType> type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
