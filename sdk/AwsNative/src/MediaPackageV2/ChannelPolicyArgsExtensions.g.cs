// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.MediaPackageV2;

public static partial class ChannelPolicyArgsExtensions
{
    public static global::Pulumi.AwsNative.MediaPackageV2.ChannelPolicyArgs WithChannelGroupName(this global::Pulumi.AwsNative.MediaPackageV2.ChannelPolicyArgs @selfRef, global::System.String channelGroupName)
    {
        @selfRef.ChannelGroupName = channelGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaPackageV2.ChannelPolicyArgs WithChannelName(this global::Pulumi.AwsNative.MediaPackageV2.ChannelPolicyArgs @selfRef, global::System.String channelName)
    {
        @selfRef.ChannelName = channelName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaPackageV2.ChannelPolicyArgs WithPolicy(this global::Pulumi.AwsNative.MediaPackageV2.ChannelPolicyArgs @selfRef, global::System.Object policy)
    {
        @selfRef.Policy = policy;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaPackageV2.ChannelPolicyArgs WithPolicy(this global::Pulumi.AwsNative.MediaPackageV2.ChannelPolicyArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Policy = @item;
        return @selfRef;
    }

}
