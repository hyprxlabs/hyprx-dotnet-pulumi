// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ses.Inputs;

namespace Pulumi.AwsNative.Ses;

public static partial class MailManagerRuleSetRuleBooleanToEvaluate0PropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetRuleBooleanToEvaluate0PropertiesArgs WithAttribute(this global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetRuleBooleanToEvaluate0PropertiesArgs @selfRef, global::Pulumi.AwsNative.Ses.MailManagerRuleSetRuleBooleanEmailAttribute attribute)
    {
        @selfRef.Attribute = attribute;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetRuleBooleanToEvaluate0PropertiesArgs WithAttribute(this global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetRuleBooleanToEvaluate0PropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ses.MailManagerRuleSetRuleBooleanEmailAttribute> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Ses.MailManagerRuleSetRuleBooleanEmailAttribute>();
        @configure(@item);
        @selfRef.Attribute = @item;
        return @selfRef;
    }

}
