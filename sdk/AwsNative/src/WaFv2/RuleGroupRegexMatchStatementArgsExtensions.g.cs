// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.WaFv2.Inputs;

namespace Pulumi.AwsNative.WaFv2;

public static partial class RuleGroupRegexMatchStatementArgsExtensions
{
    public static global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupRegexMatchStatementArgs WithFieldToMatch(this global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupRegexMatchStatementArgs @selfRef, global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupFieldToMatchArgs fieldToMatch)
    {
        @selfRef.FieldToMatch = fieldToMatch;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupRegexMatchStatementArgs WithFieldToMatch(this global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupRegexMatchStatementArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupFieldToMatchArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupFieldToMatchArgs();
        @configure(@item);
        @selfRef.FieldToMatch = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupRegexMatchStatementArgs WithRegexString(this global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupRegexMatchStatementArgs @selfRef, global::System.String regexString)
    {
        @selfRef.RegexString = regexString;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupRegexMatchStatementArgs WithTextTransformations(this global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupRegexMatchStatementArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupTextTransformationArgs> textTransformations)
    {
        @selfRef.TextTransformations = textTransformations;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupRegexMatchStatementArgs WithTextTransformations(this global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupRegexMatchStatementArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupTextTransformationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupTextTransformationArgs>();
        @configure(@list);
        @selfRef.TextTransformations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupRegexMatchStatementArgs WithTextTransformations(this global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupRegexMatchStatementArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupTextTransformationArgs>> @create)
    {
        @selfRef.TextTransformations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
