// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Pipes.Inputs;

namespace Pulumi.AwsNative.Pipes;

public static partial class PipeEcsResourceRequirementArgsExtensions
{
    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeEcsResourceRequirementArgs WithType(this global::Pulumi.AwsNative.Pipes.Inputs.PipeEcsResourceRequirementArgs @selfRef, global::Pulumi.AwsNative.Pipes.PipeEcsResourceRequirementType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeEcsResourceRequirementArgs WithType(this global::Pulumi.AwsNative.Pipes.Inputs.PipeEcsResourceRequirementArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Pipes.PipeEcsResourceRequirementType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Pipes.PipeEcsResourceRequirementType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipeEcsResourceRequirementArgs WithValue(this global::Pulumi.AwsNative.Pipes.Inputs.PipeEcsResourceRequirementArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
