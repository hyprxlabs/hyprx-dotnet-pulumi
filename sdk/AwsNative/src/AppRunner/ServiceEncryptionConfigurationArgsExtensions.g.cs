// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AppRunner.Inputs;

namespace Pulumi.AwsNative.AppRunner;

public static partial class ServiceEncryptionConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.AppRunner.Inputs.ServiceEncryptionConfigurationArgs WithKmsKey(this global::Pulumi.AwsNative.AppRunner.Inputs.ServiceEncryptionConfigurationArgs @selfRef, global::System.String kmsKey)
    {
        @selfRef.KmsKey = kmsKey;
        return @selfRef;
    }

}
