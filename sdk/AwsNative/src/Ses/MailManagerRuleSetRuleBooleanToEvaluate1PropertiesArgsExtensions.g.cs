// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ses.Inputs;

namespace Pulumi.AwsNative.Ses;

public static partial class MailManagerRuleSetRuleBooleanToEvaluate1PropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetRuleBooleanToEvaluate1PropertiesArgs WithAnalysis(this global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetRuleBooleanToEvaluate1PropertiesArgs @selfRef, global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetAnalysisArgs analysis)
    {
        @selfRef.Analysis = analysis;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetRuleBooleanToEvaluate1PropertiesArgs WithAnalysis(this global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetRuleBooleanToEvaluate1PropertiesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetAnalysisArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ses.Inputs.MailManagerRuleSetAnalysisArgs();
        @configure(@item);
        @selfRef.Analysis = @item;
        return @selfRef;
    }

}
