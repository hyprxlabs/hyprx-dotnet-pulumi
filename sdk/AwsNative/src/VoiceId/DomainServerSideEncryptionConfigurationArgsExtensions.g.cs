// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.VoiceId.Inputs;

namespace Pulumi.AwsNative.VoiceId;

public static partial class DomainServerSideEncryptionConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.VoiceId.Inputs.DomainServerSideEncryptionConfigurationArgs WithKmsKeyId(this global::Pulumi.AwsNative.VoiceId.Inputs.DomainServerSideEncryptionConfigurationArgs @selfRef, global::System.String kmsKeyId)
    {
        @selfRef.KmsKeyId = kmsKeyId;
        return @selfRef;
    }

}
