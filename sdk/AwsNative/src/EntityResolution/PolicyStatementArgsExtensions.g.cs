// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.EntityResolution;

public static partial class PolicyStatementArgsExtensions
{
    public static global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs WithAction(this global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs @selfRef, global::System.Collections.Generic.List<global::System.String> action)
    {
        @selfRef.Action = action;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs WithAction(this global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Action = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs WithAction(this global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Action = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs WithArn(this global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs @selfRef, global::System.String arn)
    {
        @selfRef.Arn = arn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs WithCondition(this global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs @selfRef, global::System.String condition)
    {
        @selfRef.Condition = condition;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs WithEffect(this global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs @selfRef, global::Pulumi.AwsNative.EntityResolution.PolicyStatementStatementEffect effect)
    {
        @selfRef.Effect = effect;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs WithEffect(this global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.EntityResolution.PolicyStatementStatementEffect> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.EntityResolution.PolicyStatementStatementEffect>();
        @configure(@item);
        @selfRef.Effect = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs WithPrincipal(this global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs @selfRef, global::System.Collections.Generic.List<global::System.String> principal)
    {
        @selfRef.Principal = principal;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs WithPrincipal(this global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Principal = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs WithPrincipal(this global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Principal = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs WithStatementId(this global::Pulumi.AwsNative.EntityResolution.PolicyStatementArgs @selfRef, global::System.String statementId)
    {
        @selfRef.StatementId = statementId;
        return @selfRef;
    }

}
