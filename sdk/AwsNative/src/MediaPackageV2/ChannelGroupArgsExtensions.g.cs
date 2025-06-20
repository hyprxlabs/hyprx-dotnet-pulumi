// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.MediaPackageV2;

public static partial class ChannelGroupArgsExtensions
{
    public static global::Pulumi.AwsNative.MediaPackageV2.ChannelGroupArgs WithChannelGroupName(this global::Pulumi.AwsNative.MediaPackageV2.ChannelGroupArgs @selfRef, global::System.String channelGroupName)
    {
        @selfRef.ChannelGroupName = channelGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaPackageV2.ChannelGroupArgs WithDescription(this global::Pulumi.AwsNative.MediaPackageV2.ChannelGroupArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaPackageV2.ChannelGroupArgs WithTags(this global::Pulumi.AwsNative.MediaPackageV2.ChannelGroupArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaPackageV2.ChannelGroupArgs WithTags(this global::Pulumi.AwsNative.MediaPackageV2.ChannelGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaPackageV2.ChannelGroupArgs WithTags(this global::Pulumi.AwsNative.MediaPackageV2.ChannelGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
