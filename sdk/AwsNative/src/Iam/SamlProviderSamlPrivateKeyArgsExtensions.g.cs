// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Iam.Inputs;

namespace Pulumi.AwsNative.Iam;

public static partial class SamlProviderSamlPrivateKeyArgsExtensions
{
    public static global::Pulumi.AwsNative.Iam.Inputs.SamlProviderSamlPrivateKeyArgs WithKeyId(this global::Pulumi.AwsNative.Iam.Inputs.SamlProviderSamlPrivateKeyArgs @selfRef, global::System.String keyId)
    {
        @selfRef.KeyId = keyId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Iam.Inputs.SamlProviderSamlPrivateKeyArgs WithTimestamp(this global::Pulumi.AwsNative.Iam.Inputs.SamlProviderSamlPrivateKeyArgs @selfRef, global::System.String timestamp)
    {
        @selfRef.Timestamp = timestamp;
        return @selfRef;
    }

}
