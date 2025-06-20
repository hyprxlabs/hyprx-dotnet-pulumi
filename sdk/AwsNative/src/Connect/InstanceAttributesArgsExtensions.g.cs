// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Connect.Inputs;

namespace Pulumi.AwsNative.Connect;

public static partial class InstanceAttributesArgsExtensions
{
    public static global::Pulumi.AwsNative.Connect.Inputs.InstanceAttributesArgs WithAutoResolveBestVoices(this global::Pulumi.AwsNative.Connect.Inputs.InstanceAttributesArgs @selfRef, bool autoResolveBestVoices = true)
    {
        @selfRef.AutoResolveBestVoices = autoResolveBestVoices;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.Inputs.InstanceAttributesArgs WithContactLens(this global::Pulumi.AwsNative.Connect.Inputs.InstanceAttributesArgs @selfRef, bool contactLens = true)
    {
        @selfRef.ContactLens = contactLens;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.Inputs.InstanceAttributesArgs WithContactflowLogs(this global::Pulumi.AwsNative.Connect.Inputs.InstanceAttributesArgs @selfRef, bool contactflowLogs = true)
    {
        @selfRef.ContactflowLogs = contactflowLogs;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.Inputs.InstanceAttributesArgs WithEarlyMedia(this global::Pulumi.AwsNative.Connect.Inputs.InstanceAttributesArgs @selfRef, bool earlyMedia = true)
    {
        @selfRef.EarlyMedia = earlyMedia;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.Inputs.InstanceAttributesArgs WithInboundCalls(this global::Pulumi.AwsNative.Connect.Inputs.InstanceAttributesArgs @selfRef, bool inboundCalls = true)
    {
        @selfRef.InboundCalls = inboundCalls;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.Inputs.InstanceAttributesArgs WithOutboundCalls(this global::Pulumi.AwsNative.Connect.Inputs.InstanceAttributesArgs @selfRef, bool outboundCalls = true)
    {
        @selfRef.OutboundCalls = outboundCalls;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.Inputs.InstanceAttributesArgs WithUseCustomTtsVoices(this global::Pulumi.AwsNative.Connect.Inputs.InstanceAttributesArgs @selfRef, bool useCustomTtsVoices = true)
    {
        @selfRef.UseCustomTtsVoices = useCustomTtsVoices;
        return @selfRef;
    }

}
