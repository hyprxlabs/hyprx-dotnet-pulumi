// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.MediaConnect.Inputs;

namespace Pulumi.AwsNative.MediaConnect;

public static partial class FlowMediaStreamArgsExtensions
{
    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs WithAttributes(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs @selfRef, global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamAttributesArgs attributes)
    {
        @selfRef.Attributes = attributes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs WithAttributes(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamAttributesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamAttributesArgs();
        @configure(@item);
        @selfRef.Attributes = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs WithClockRate(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs @selfRef, global::System.Int32 clockRate)
    {
        @selfRef.ClockRate = clockRate;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs WithDescription(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs WithFmt(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs @selfRef, global::System.Int32 fmt)
    {
        @selfRef.Fmt = fmt;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs WithMediaStreamId(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs @selfRef, global::System.Int32 mediaStreamId)
    {
        @selfRef.MediaStreamId = mediaStreamId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs WithMediaStreamName(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs @selfRef, global::System.String mediaStreamName)
    {
        @selfRef.MediaStreamName = mediaStreamName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs WithMediaStreamType(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs @selfRef, global::Pulumi.AwsNative.MediaConnect.FlowMediaStreamMediaStreamType mediaStreamType)
    {
        @selfRef.MediaStreamType = mediaStreamType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs WithMediaStreamType(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.MediaConnect.FlowMediaStreamMediaStreamType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.MediaConnect.FlowMediaStreamMediaStreamType>();
        @configure(@item);
        @selfRef.MediaStreamType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs WithVideoFormat(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs @selfRef, global::Pulumi.AwsNative.MediaConnect.FlowMediaStreamVideoFormat videoFormat)
    {
        @selfRef.VideoFormat = videoFormat;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs WithVideoFormat(this global::Pulumi.AwsNative.MediaConnect.Inputs.FlowMediaStreamArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.MediaConnect.FlowMediaStreamVideoFormat> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.MediaConnect.FlowMediaStreamVideoFormat>();
        @configure(@item);
        @selfRef.VideoFormat = @item;
        return @selfRef;
    }

}
