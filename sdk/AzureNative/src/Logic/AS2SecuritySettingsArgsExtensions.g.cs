// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Logic.Inputs;

namespace Pulumi.AzureNative.Logic;

public static partial class AS2SecuritySettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs WithEnableNRRForInboundDecodedMessages(this global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs @selfRef, bool enableNRRForInboundDecodedMessages = true)
    {
        @selfRef.EnableNRRForInboundDecodedMessages = enableNRRForInboundDecodedMessages;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs WithEnableNRRForInboundEncodedMessages(this global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs @selfRef, bool enableNRRForInboundEncodedMessages = true)
    {
        @selfRef.EnableNRRForInboundEncodedMessages = enableNRRForInboundEncodedMessages;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs WithEnableNRRForInboundMDN(this global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs @selfRef, bool enableNRRForInboundMDN = true)
    {
        @selfRef.EnableNRRForInboundMDN = enableNRRForInboundMDN;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs WithEnableNRRForOutboundDecodedMessages(this global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs @selfRef, bool enableNRRForOutboundDecodedMessages = true)
    {
        @selfRef.EnableNRRForOutboundDecodedMessages = enableNRRForOutboundDecodedMessages;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs WithEnableNRRForOutboundEncodedMessages(this global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs @selfRef, bool enableNRRForOutboundEncodedMessages = true)
    {
        @selfRef.EnableNRRForOutboundEncodedMessages = enableNRRForOutboundEncodedMessages;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs WithEnableNRRForOutboundMDN(this global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs @selfRef, bool enableNRRForOutboundMDN = true)
    {
        @selfRef.EnableNRRForOutboundMDN = enableNRRForOutboundMDN;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs WithEncryptionCertificateName(this global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs @selfRef, global::System.String encryptionCertificateName)
    {
        @selfRef.EncryptionCertificateName = encryptionCertificateName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs WithOverrideGroupSigningCertificate(this global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs @selfRef, bool overrideGroupSigningCertificate = true)
    {
        @selfRef.OverrideGroupSigningCertificate = overrideGroupSigningCertificate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs WithSha2AlgorithmFormat(this global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs @selfRef, global::System.String sha2AlgorithmFormat)
    {
        @selfRef.Sha2AlgorithmFormat = sha2AlgorithmFormat;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs WithSigningCertificateName(this global::Pulumi.AzureNative.Logic.Inputs.AS2SecuritySettingsArgs @selfRef, global::System.String signingCertificateName)
    {
        @selfRef.SigningCertificateName = signingCertificateName;
        return @selfRef;
    }

}
