// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.MediaPackage.Inputs;

namespace Pulumi.AwsNative.MediaPackage;

public static partial class OriginEndpointHlsEncryptionArgsExtensions
{
    public static global::Pulumi.AwsNative.MediaPackage.Inputs.OriginEndpointHlsEncryptionArgs WithConstantInitializationVector(this global::Pulumi.AwsNative.MediaPackage.Inputs.OriginEndpointHlsEncryptionArgs @selfRef, global::System.String constantInitializationVector)
    {
        @selfRef.ConstantInitializationVector = constantInitializationVector;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaPackage.Inputs.OriginEndpointHlsEncryptionArgs WithEncryptionMethod(this global::Pulumi.AwsNative.MediaPackage.Inputs.OriginEndpointHlsEncryptionArgs @selfRef, global::Pulumi.AwsNative.MediaPackage.OriginEndpointHlsEncryptionEncryptionMethod encryptionMethod)
    {
        @selfRef.EncryptionMethod = encryptionMethod;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaPackage.Inputs.OriginEndpointHlsEncryptionArgs WithEncryptionMethod(this global::Pulumi.AwsNative.MediaPackage.Inputs.OriginEndpointHlsEncryptionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.MediaPackage.OriginEndpointHlsEncryptionEncryptionMethod> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.MediaPackage.OriginEndpointHlsEncryptionEncryptionMethod>();
        @configure(@item);
        @selfRef.EncryptionMethod = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaPackage.Inputs.OriginEndpointHlsEncryptionArgs WithKeyRotationIntervalSeconds(this global::Pulumi.AwsNative.MediaPackage.Inputs.OriginEndpointHlsEncryptionArgs @selfRef, global::System.Int32 keyRotationIntervalSeconds)
    {
        @selfRef.KeyRotationIntervalSeconds = keyRotationIntervalSeconds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaPackage.Inputs.OriginEndpointHlsEncryptionArgs WithRepeatExtXKey(this global::Pulumi.AwsNative.MediaPackage.Inputs.OriginEndpointHlsEncryptionArgs @selfRef, bool repeatExtXKey = true)
    {
        @selfRef.RepeatExtXKey = repeatExtXKey;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaPackage.Inputs.OriginEndpointHlsEncryptionArgs WithSpekeKeyProvider(this global::Pulumi.AwsNative.MediaPackage.Inputs.OriginEndpointHlsEncryptionArgs @selfRef, global::Pulumi.AwsNative.MediaPackage.Inputs.OriginEndpointSpekeKeyProviderArgs spekeKeyProvider)
    {
        @selfRef.SpekeKeyProvider = spekeKeyProvider;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaPackage.Inputs.OriginEndpointHlsEncryptionArgs WithSpekeKeyProvider(this global::Pulumi.AwsNative.MediaPackage.Inputs.OriginEndpointHlsEncryptionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.MediaPackage.Inputs.OriginEndpointSpekeKeyProviderArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.MediaPackage.Inputs.OriginEndpointSpekeKeyProviderArgs();
        @configure(@item);
        @selfRef.SpekeKeyProvider = @item;
        return @selfRef;
    }

}
