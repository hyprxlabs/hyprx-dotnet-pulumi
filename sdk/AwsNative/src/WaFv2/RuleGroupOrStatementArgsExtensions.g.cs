// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.WaFv2.Inputs;

namespace Pulumi.AwsNative.WaFv2;

public static partial class RuleGroupOrStatementArgsExtensions
{
    public static global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupOrStatementArgs WithStatements(this global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupOrStatementArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupStatementArgs> statements)
    {
        @selfRef.Statements = statements;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupOrStatementArgs WithStatements(this global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupOrStatementArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupStatementArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupStatementArgs>();
        @configure(@list);
        @selfRef.Statements = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupOrStatementArgs WithStatements(this global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupOrStatementArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.WaFv2.Inputs.RuleGroupStatementArgs>> @create)
    {
        @selfRef.Statements = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
