// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.WaFv2.Inputs;

namespace Pulumi.AwsNative.WaFv2;

public static partial class WebAclOnSourceDDoSProtectionConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclOnSourceDDoSProtectionConfigArgs WithAlbLowReputationMode(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclOnSourceDDoSProtectionConfigArgs @selfRef, global::Pulumi.AwsNative.WaFv2.WebAclOnSourceDDoSProtectionConfigAlbLowReputationMode albLowReputationMode)
    {
        @selfRef.AlbLowReputationMode = albLowReputationMode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclOnSourceDDoSProtectionConfigArgs WithAlbLowReputationMode(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclOnSourceDDoSProtectionConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.WaFv2.WebAclOnSourceDDoSProtectionConfigAlbLowReputationMode> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.WaFv2.WebAclOnSourceDDoSProtectionConfigAlbLowReputationMode>();
        @configure(@item);
        @selfRef.AlbLowReputationMode = @item;
        return @selfRef;
    }

}
