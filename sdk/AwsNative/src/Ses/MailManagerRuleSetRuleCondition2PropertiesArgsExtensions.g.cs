// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ses.Inputs;

namespace Pulumi.AwsNative.Ses;

public static partial class MailManagerRuleSetRuleCondition2PropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetRuleCondition2PropertiesArgs WithNumberExpression(this global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetRuleCondition2PropertiesArgs @selfRef, global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetRuleNumberExpressionArgs numberExpression)
    {
        @selfRef.NumberExpression = numberExpression;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetRuleCondition2PropertiesArgs WithNumberExpression(this global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetRuleCondition2PropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetRuleNumberExpressionArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetRuleNumberExpressionArgs();
        @configure(@item);
        @selfRef.NumberExpression = @item;
        return @selfRef;
    }

}
