// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.WaFv2.Inputs;

namespace Pulumi.AwsNative.WaFv2;

public static partial class WebAclClientSideActionConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclClientSideActionConfigArgs WithChallenge(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclClientSideActionConfigArgs @selfRef, global::Pulumi.AwsNative.WaFv2.Inputs.WebAclClientSideActionArgs challenge)
    {
        @selfRef.Challenge = challenge;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclClientSideActionConfigArgs WithChallenge(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclClientSideActionConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclClientSideActionArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.WaFv2.Inputs.WebAclClientSideActionArgs();
        @configure(@item);
        @selfRef.Challenge = @item;
        return @selfRef;
    }

}
