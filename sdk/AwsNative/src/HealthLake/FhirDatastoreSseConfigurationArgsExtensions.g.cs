// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.HealthLake.Inputs;

namespace Pulumi.AwsNative.HealthLake;

public static partial class FhirDatastoreSseConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.HealthLake.Inputs.FhirDatastoreSseConfigurationArgs WithKmsEncryptionConfig(this global::Pulumi.AwsNative.HealthLake.Inputs.FhirDatastoreSseConfigurationArgs @selfRef, global::Pulumi.AwsNative.HealthLake.Inputs.FhirDatastoreKmsEncryptionConfigArgs kmsEncryptionConfig)
    {
        @selfRef.KmsEncryptionConfig = kmsEncryptionConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.HealthLake.Inputs.FhirDatastoreSseConfigurationArgs WithKmsEncryptionConfig(this global::Pulumi.AwsNative.HealthLake.Inputs.FhirDatastoreSseConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.HealthLake.Inputs.FhirDatastoreKmsEncryptionConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.HealthLake.Inputs.FhirDatastoreKmsEncryptionConfigArgs();
        @configure(@item);
        @selfRef.KmsEncryptionConfig = @item;
        return @selfRef;
    }

}
