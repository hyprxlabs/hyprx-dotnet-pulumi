// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Lex.Inputs;

namespace Pulumi.AwsNative.Lex;

public static partial class BotSessionAttributeArgsExtensions
{
    public static global::Pulumi.AwsNative.Lex.Inputs.BotSessionAttributeArgs WithKey(this global::Pulumi.AwsNative.Lex.Inputs.BotSessionAttributeArgs @selfRef, global::System.String key)
    {
        @selfRef.Key = key;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lex.Inputs.BotSessionAttributeArgs WithValue(this global::Pulumi.AwsNative.Lex.Inputs.BotSessionAttributeArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
