// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Pipes.Inputs;

namespace Pulumi.AwsNative.Pipes;

public static partial class PipePlacementConstraintArgsExtensions
{
    public static global::Pulumi.AwsNative.Pipes.Inputs.PipePlacementConstraintArgs WithExpression(this global::Pulumi.AwsNative.Pipes.Inputs.PipePlacementConstraintArgs @selfRef, global::System.String expression)
    {
        @selfRef.Expression = expression;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipePlacementConstraintArgs WithType(this global::Pulumi.AwsNative.Pipes.Inputs.PipePlacementConstraintArgs @selfRef, global::Pulumi.AwsNative.Pipes.PipePlacementConstraintType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Pipes.Inputs.PipePlacementConstraintArgs WithType(this global::Pulumi.AwsNative.Pipes.Inputs.PipePlacementConstraintArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Pipes.PipePlacementConstraintType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Pipes.PipePlacementConstraintType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
