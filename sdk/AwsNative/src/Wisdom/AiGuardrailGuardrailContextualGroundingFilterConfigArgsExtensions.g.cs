// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Wisdom.Inputs;

namespace Pulumi.AwsNative.Wisdom;

public static partial class AiGuardrailGuardrailContextualGroundingFilterConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailContextualGroundingFilterConfigArgs WithThreshold(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailContextualGroundingFilterConfigArgs @selfRef, global::System.Double threshold)
    {
        @selfRef.Threshold = threshold;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailContextualGroundingFilterConfigArgs WithType(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailContextualGroundingFilterConfigArgs @selfRef, global::Pulumi.AwsNative.Wisdom.AiGuardrailGuardrailContextualGroundingFilterType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailContextualGroundingFilterConfigArgs WithType(this global::Pulumi.AwsNative.Wisdom.Inputs.AiGuardrailGuardrailContextualGroundingFilterConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Wisdom.AiGuardrailGuardrailContextualGroundingFilterType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Wisdom.AiGuardrailGuardrailContextualGroundingFilterType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
