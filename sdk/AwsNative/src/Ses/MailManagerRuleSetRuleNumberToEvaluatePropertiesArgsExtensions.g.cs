// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ses.Inputs;

namespace Pulumi.AwsNative.Ses;

public static partial class MailManagerRuleSetRuleNumberToEvaluatePropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetRuleNumberToEvaluatePropertiesArgs WithAttribute(this global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetRuleNumberToEvaluatePropertiesArgs @selfRef, global::Pulumi.AwsNative.Ses.MailManagerRuleSetRuleNumberEmailAttribute attribute)
    {
        @selfRef.Attribute = attribute;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetRuleNumberToEvaluatePropertiesArgs WithAttribute(this global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetRuleNumberToEvaluatePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ses.MailManagerRuleSetRuleNumberEmailAttribute> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Ses.MailManagerRuleSetRuleNumberEmailAttribute>();
        @configure(@item);
        @selfRef.Attribute = @item;
        return @selfRef;
    }

}
