// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.CustomerProfiles.Inputs;

namespace Pulumi.AwsNative.CustomerProfiles;

public static partial class CalculatedAttributeDefinitionAttributeDetailsArgsExtensions
{
    public static global::Pulumi.AwsNative.CustomerProfiles.Inputs.CalculatedAttributeDefinitionAttributeDetailsArgs WithAttributes(this global::Pulumi.AwsNative.CustomerProfiles.Inputs.CalculatedAttributeDefinitionAttributeDetailsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.CustomerProfiles.Inputs.CalculatedAttributeDefinitionAttributeItemArgs> attributes)
    {
        @selfRef.Attributes = attributes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CustomerProfiles.Inputs.CalculatedAttributeDefinitionAttributeDetailsArgs WithAttributes(this global::Pulumi.AwsNative.CustomerProfiles.Inputs.CalculatedAttributeDefinitionAttributeDetailsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.CustomerProfiles.Inputs.CalculatedAttributeDefinitionAttributeItemArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.CustomerProfiles.Inputs.CalculatedAttributeDefinitionAttributeItemArgs>();
        @configure(@list);
        @selfRef.Attributes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CustomerProfiles.Inputs.CalculatedAttributeDefinitionAttributeDetailsArgs WithAttributes(this global::Pulumi.AwsNative.CustomerProfiles.Inputs.CalculatedAttributeDefinitionAttributeDetailsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.CustomerProfiles.Inputs.CalculatedAttributeDefinitionAttributeItemArgs>> @create)
    {
        @selfRef.Attributes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CustomerProfiles.Inputs.CalculatedAttributeDefinitionAttributeDetailsArgs WithExpression(this global::Pulumi.AwsNative.CustomerProfiles.Inputs.CalculatedAttributeDefinitionAttributeDetailsArgs @selfRef, global::System.String expression)
    {
        @selfRef.Expression = expression;
        return @selfRef;
    }

}
