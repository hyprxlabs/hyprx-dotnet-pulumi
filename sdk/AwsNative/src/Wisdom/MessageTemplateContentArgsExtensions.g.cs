// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Wisdom.Inputs;

namespace Pulumi.AwsNative.Wisdom;

public static partial class MessageTemplateContentArgsExtensions
{
    public static global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateContentArgs WithEmailMessageTemplateContent(this global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateContentArgs @selfRef, global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateEmailMessageTemplateContentArgs emailMessageTemplateContent)
    {
        @selfRef.EmailMessageTemplateContent = emailMessageTemplateContent;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateContentArgs WithEmailMessageTemplateContent(this global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateContentArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateEmailMessageTemplateContentArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateEmailMessageTemplateContentArgs();
        @configure(@item);
        @selfRef.EmailMessageTemplateContent = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateContentArgs WithSmsMessageTemplateContent(this global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateContentArgs @selfRef, global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateSmsMessageTemplateContentArgs smsMessageTemplateContent)
    {
        @selfRef.SmsMessageTemplateContent = smsMessageTemplateContent;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateContentArgs WithSmsMessageTemplateContent(this global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateContentArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateSmsMessageTemplateContentArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Wisdom.Inputs.MessageTemplateSmsMessageTemplateContentArgs();
        @configure(@item);
        @selfRef.SmsMessageTemplateContent = @item;
        return @selfRef;
    }

}
