// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.WaFv2.Inputs;

namespace Pulumi.AwsNative.WaFv2;

public static partial class WebAclAndStatementArgsExtensions
{
    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclAndStatementArgs WithStatements(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclAndStatementArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclStatementArgs> statements)
    {
        @selfRef.Statements = statements;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclAndStatementArgs WithStatements(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclAndStatementArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclStatementArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclStatementArgs>();
        @configure(@list);
        @selfRef.Statements = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclAndStatementArgs WithStatements(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclAndStatementArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclStatementArgs>> @create)
    {
        @selfRef.Statements = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
