// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoT.Inputs;

namespace Pulumi.AwsNative.IoT;

public static partial class TopicRuleTimestampArgsExtensions
{
    public static global::Pulumi.AwsNative.IoT.Inputs.TopicRuleTimestampArgs WithUnit(this global::Pulumi.AwsNative.IoT.Inputs.TopicRuleTimestampArgs @selfRef, global::System.String unit)
    {
        @selfRef.Unit = unit;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.TopicRuleTimestampArgs WithValue(this global::Pulumi.AwsNative.IoT.Inputs.TopicRuleTimestampArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
