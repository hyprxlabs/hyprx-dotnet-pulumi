// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Pipes.Inputs;

namespace Pulumi.AwsNative.Pipes;

public static partial class PipeTagArgsExtensions
{
    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeTagArgs WithKey(this global::Pulumi.AwsNative.Pipes.Inputs.PipeTagArgs @selfRef, global::System.String key)
    {
        @selfRef.Key = key;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeTagArgs WithValue(this global::Pulumi.AwsNative.Pipes.Inputs.PipeTagArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
