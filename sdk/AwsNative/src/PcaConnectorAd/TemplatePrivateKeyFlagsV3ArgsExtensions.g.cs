// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.PcaConnectorAd.Inputs;

namespace Pulumi.AwsNative.PcaConnectorAd;

public static partial class TemplatePrivateKeyFlagsV3ArgsExtensions
{
    public static global::Pulumi.AwsNative.PcaConnectorAd.Inputs.TemplatePrivateKeyFlagsV3Args WithClientVersion(this global::Pulumi.AwsNative.PcaConnectorAd.Inputs.TemplatePrivateKeyFlagsV3Args @selfRef, global::Pulumi.AwsNative.PcaConnectorAd.TemplateClientCompatibilityV3 clientVersion)
    {
        @selfRef.ClientVersion = clientVersion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.PcaConnectorAd.Inputs.TemplatePrivateKeyFlagsV3Args WithClientVersion(this global::Pulumi.AwsNative.PcaConnectorAd.Inputs.TemplatePrivateKeyFlagsV3Args @selfRef, global::System.Action<global::Pulumi.AwsNative.PcaConnectorAd.TemplateClientCompatibilityV3> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.PcaConnectorAd.TemplateClientCompatibilityV3>();
        @configure(@item);
        @selfRef.ClientVersion = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.PcaConnectorAd.Inputs.TemplatePrivateKeyFlagsV3Args WithExportableKey(this global::Pulumi.AwsNative.PcaConnectorAd.Inputs.TemplatePrivateKeyFlagsV3Args @selfRef, bool exportableKey = true)
    {
        @selfRef.ExportableKey = exportableKey;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.PcaConnectorAd.Inputs.TemplatePrivateKeyFlagsV3Args WithRequireAlternateSignatureAlgorithm(this global::Pulumi.AwsNative.PcaConnectorAd.Inputs.TemplatePrivateKeyFlagsV3Args @selfRef, bool requireAlternateSignatureAlgorithm = true)
    {
        @selfRef.RequireAlternateSignatureAlgorithm = requireAlternateSignatureAlgorithm;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.PcaConnectorAd.Inputs.TemplatePrivateKeyFlagsV3Args WithStrongKeyProtectionRequired(this global::Pulumi.AwsNative.PcaConnectorAd.Inputs.TemplatePrivateKeyFlagsV3Args @selfRef, bool strongKeyProtectionRequired = true)
    {
        @selfRef.StrongKeyProtectionRequired = strongKeyProtectionRequired;
        return @selfRef;
    }

}
