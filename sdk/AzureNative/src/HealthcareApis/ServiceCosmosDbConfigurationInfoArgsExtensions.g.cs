// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HealthcareApis.Inputs;

namespace Pulumi.AzureNative.HealthcareApis;

public static partial class ServiceCosmosDbConfigurationInfoArgsExtensions
{
    public static global::Pulumi.AzureNative.HealthcareApis.Inputs.ServiceCosmosDbConfigurationInfoArgs WithCrossTenantCmkApplicationId(this global::Pulumi.AzureNative.HealthcareApis.Inputs.ServiceCosmosDbConfigurationInfoArgs @selfRef, global::System.String crossTenantCmkApplicationId)
    {
        @selfRef.CrossTenantCmkApplicationId = crossTenantCmkApplicationId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HealthcareApis.Inputs.ServiceCosmosDbConfigurationInfoArgs WithKeyVaultKeyUri(this global::Pulumi.AzureNative.HealthcareApis.Inputs.ServiceCosmosDbConfigurationInfoArgs @selfRef, global::System.String keyVaultKeyUri)
    {
        @selfRef.KeyVaultKeyUri = keyVaultKeyUri;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HealthcareApis.Inputs.ServiceCosmosDbConfigurationInfoArgs WithOfferThroughput(this global::Pulumi.AzureNative.HealthcareApis.Inputs.ServiceCosmosDbConfigurationInfoArgs @selfRef, global::System.Int32 offerThroughput)
    {
        @selfRef.OfferThroughput = offerThroughput;
        return @selfRef;
    }

}
