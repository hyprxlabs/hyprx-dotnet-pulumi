// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Wisdom.Inputs;

namespace Pulumi.AwsNative.Wisdom;

public static partial class MessageTemplateSystemAttributesArgsExtensions
{
    public static global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateSystemAttributesArgs WithCustomerEndpoint(this global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateSystemAttributesArgs @selfRef, global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateSystemEndpointAttributesArgs customerEndpoint)
    {
        @selfRef.CustomerEndpoint = customerEndpoint;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateSystemAttributesArgs WithCustomerEndpoint(this global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateSystemAttributesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateSystemEndpointAttributesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateSystemEndpointAttributesArgs();
        @configure(@item);
        @selfRef.CustomerEndpoint = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateSystemAttributesArgs WithName(this global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateSystemAttributesArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateSystemAttributesArgs WithSystemEndpoint(this global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateSystemAttributesArgs @selfRef, global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateSystemEndpointAttributesArgs systemEndpoint)
    {
        @selfRef.SystemEndpoint = systemEndpoint;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateSystemAttributesArgs WithSystemEndpoint(this global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateSystemAttributesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateSystemEndpointAttributesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateSystemEndpointAttributesArgs();
        @configure(@item);
        @selfRef.SystemEndpoint = @item;
        return @selfRef;
    }

}
