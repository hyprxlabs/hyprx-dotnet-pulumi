// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.NimbleStudio.Inputs;

namespace Pulumi.AwsNative.NimbleStudio;

public static partial class StudioEncryptionConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.NimbleStudio.Inputs.StudioEncryptionConfigurationArgs WithKeyArn(this global::Pulumi.AwsNative.NimbleStudio.Inputs.StudioEncryptionConfigurationArgs @selfRef, global::System.String keyArn)
    {
        @selfRef.KeyArn = keyArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NimbleStudio.Inputs.StudioEncryptionConfigurationArgs WithKeyType(this global::Pulumi.AwsNative.NimbleStudio.Inputs.StudioEncryptionConfigurationArgs @selfRef, global::System.String keyType)
    {
        @selfRef.KeyType = keyType;
        return @selfRef;
    }

}
