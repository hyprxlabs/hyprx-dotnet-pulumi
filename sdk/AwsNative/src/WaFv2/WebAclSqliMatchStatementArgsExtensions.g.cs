// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.WaFv2.Inputs;

namespace Pulumi.AwsNative.WaFv2;

public static partial class WebAclSqliMatchStatementArgsExtensions
{
    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclSqliMatchStatementArgs WithFieldToMatch(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclSqliMatchStatementArgs @selfRef, global::Pulumi.AwsNative.WaFv2.Inputs.WebAclFieldToMatchArgs fieldToMatch)
    {
        @selfRef.FieldToMatch = fieldToMatch;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclSqliMatchStatementArgs WithFieldToMatch(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclSqliMatchStatementArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclFieldToMatchArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.WaFv2.Inputs.WebAclFieldToMatchArgs();
        @configure(@item);
        @selfRef.FieldToMatch = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclSqliMatchStatementArgs WithSensitivityLevel(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclSqliMatchStatementArgs @selfRef, global::Pulumi.AwsNative.WaFv2.WebAclSensitivityLevel sensitivityLevel)
    {
        @selfRef.SensitivityLevel = sensitivityLevel;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclSqliMatchStatementArgs WithSensitivityLevel(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclSqliMatchStatementArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.WaFv2.WebAclSensitivityLevel> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.WaFv2.WebAclSensitivityLevel>();
        @configure(@item);
        @selfRef.SensitivityLevel = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclSqliMatchStatementArgs WithTextTransformations(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclSqliMatchStatementArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclTextTransformationArgs> textTransformations)
    {
        @selfRef.TextTransformations = textTransformations;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclSqliMatchStatementArgs WithTextTransformations(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclSqliMatchStatementArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclTextTransformationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclTextTransformationArgs>();
        @configure(@list);
        @selfRef.TextTransformations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.WaFv2.Inputs.WebAclSqliMatchStatementArgs WithTextTransformations(this global::Pulumi.AwsNative.WaFv2.Inputs.WebAclSqliMatchStatementArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.WaFv2.Inputs.WebAclTextTransformationArgs>> @create)
    {
        @selfRef.TextTransformations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
